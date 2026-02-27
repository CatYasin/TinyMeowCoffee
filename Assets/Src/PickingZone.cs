

using System;
using System.Collections.Generic;
using UnityEngine;

public class PickingZone : MonoBehaviour
{
    Collider2D col;
    

    [SerializeField] private LayerMask WhichItemsColect;

    private List<Collider2D> results;

    public event Action<IngredientData> OnItemCollected;

    private void Awake()
    {
        col = GetComponent<Collider2D>();
        
    }


    private void Update()
    {
        

        if (col.IsTouchingLayers(WhichItemsColect))
        {
            GetOverlapComponents();
        }
    }

    private void GetOverlapComponents()
    {
        col.Overlap(results);
        foreach (var com in results)
        {
            IPickup target = com.GetComponent<IPickup>();
            if (target != null)
            {
                OnItemCollected?.Invoke(target.GetItem());
            }
        }
    }
}
