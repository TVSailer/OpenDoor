using UnityEngine;

namespace Player
{
    public class PlayerInteractive : MonoBehaviour
    {
        [SerializeField] private Transform _camera;
        [SerializeField] private float _distancehRay;
        [SerializeField] private LayerMask _layerMask;
        private GameObject _playerUI;

        private void Start()
        {
            _playerUI = GameObject.FindWithTag("PlayerUI");
        }

        private void Update()
        {
            _playerUI.GetComponent<PlayerUI>().UpdateText("");
            Ray ray = new Ray(_camera.transform.position, _camera.forward);
            Debug.DrawRay(ray.origin, ray.direction * _distancehRay, Color.green);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, _distancehRay, _layerMask))
            {
                Interactive interct = hit.collider.GetComponent<Interactive>();

                if (interct != null)
                {
                    _playerUI.GetComponent<PlayerUI>().UpdateText(interct.Text);
                    if (Input.GetKey(KeyCode.E))
                        interct.Ev();
                }
            }
        }
    }
}