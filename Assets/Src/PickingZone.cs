

using System;
using System.Collections.Generic;
using UnityEngine;

public class PickingZone : MonoBehaviour
{
    Collider2D col;
    

    [SerializeField] private LayerMask WhichItemsColect;

    

    public event Action<IngredientData> OnItemCollected;

    private void Awake()
    {
        col = GetComponent<Collider2D>();
        
    }


    private void Update()
    {
        GetOverlapComponents();
        
    }

    private void GetOverlapComponents()
    {
        Collider2D[] tcol = Physics2D.OverlapBoxAll(col.bounds.center, col.bounds.size,0f,WhichItemsColect);

        foreach (Collider2D target in tcol)
        {
            if (target.TryGetComponent(out IPickup com))
            {
                OnItemCollected?.Invoke(com.GetItem());
            }
        }
    }
}
