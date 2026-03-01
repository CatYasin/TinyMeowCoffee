using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour, IPressable
{

    public UnityEvent OnPressed;

    public void Press()
    {
        OnPressed?.Invoke();
    }
}
