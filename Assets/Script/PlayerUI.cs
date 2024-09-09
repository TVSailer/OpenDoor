using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _textOtInteractPlayery;
    public void UpdateText(string text) => _textOtInteractPlayery.text = text;
}
