using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class OpenDoor : MonoBehaviour
{
    [SerializeField] private Transform _doorTransform;
    [SerializeField] private float _timeAnimation = 2.0f;

    private float _time = 0;
    private float _dir = 1;
    private bool _isAnimation = false;

    private Quaternion startPoint = Quaternion.Euler(0, 0, 0);
    private Quaternion endPoint = Quaternion.Euler(0, 90, 0);

    public void OnTriggerStay(Collider other)
    {
        if (_isAnimation)
            _dir = Mathf.Abs(_dir);
        else
            if (_time < 0.9)
            StartCoroutine(Animation());
    }

    public void OnTriggerExit(Collider other)
    {
        if (_isAnimation)
            _dir *= -1;
        else
            StartCoroutine(Animation());
    }

    private IEnumerator Animation()
    {
        _isAnimation = true;

        while (_time <= 1 && _time >= 0)
        {
            _doorTransform.transform.rotation = Quaternion.Lerp(startPoint, endPoint, _time);
            _time += _dir * Time.deltaTime / _timeAnimation;
            yield return null;
        }
        _isAnimation = false;

        _time = Mathf.Clamp01(_time);
        _dir *= -1;

    }
}
