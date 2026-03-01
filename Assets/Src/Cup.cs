using System;
using System.Collections.Generic;
using UnityEngine;

public class Cup : MonoBehaviour , IHoldingZoneCom
{
    HoldingZoneComponent hzc;

    PickingZone pz;

    public List<IngredientData> GetIngredients()
    {
        return hzc.GetIngredients();
    }

    public bool SetCoffee(CoffeeData coffee)
    {
        return hzc.SetCoffee(coffee);
    }

    private void Awake()
    {
        hzc = GetComponentInChildren<HoldingZoneComponent>();
        pz = GetComponentInChildren<PickingZone>();

        pz.OnItemCollected += ItemCollecting;
        
    }

    private void ItemCollecting(IngredientData data)
    {
        if (!hzc.isFull())
        {
            if (!hzc.TryAddIngredient(data))
            {
                throw new Exception(data.name + " it cant loading I dont know why");
            }
            else
            {
                Debug.Log("İt s wor king yeahh");
            }
        }
        else
        {
            Debug.Log("Im full man");
        }
    }

    
}
