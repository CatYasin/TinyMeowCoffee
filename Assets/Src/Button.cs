using System;
using Unity.VisualScripting;
using UnityEngine;

public class Button : MonoBehaviour, IPressable
{

    public event Action OnPressed;

    public void Press()
    {
        OnPressed?.Invoke();
    }
}
