using System;
using UnityEngine;
using UnityEngine.Events;

public abstract class Interactive : MonoBehaviour
{
    [SerializeField] private string _textInteract;
    public string Text => _textInteract;
    public UnityEvent EventInteraction;
    public bool isInteract;
    public void Ev()
    {
        EventInteraction?.Invoke();
    }
}
