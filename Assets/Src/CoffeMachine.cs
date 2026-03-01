
using System;
using System.Collections.Generic;
using UnityEngine;

public class CoffeMachine : MonoBehaviour
{

    PickingZone pz;

    HoldingZoneComponent hzc;

    [SerializeField] private CoffeeData[] allData;



    private void Awake()
    {
        pz = GetComponent<PickingZone>();
        hzc = GetComponent<HoldingZoneComponent>();

        pz.OnHoldingZoneCollected += HoldingZoneCollected;
    }

    private void HoldingZoneCollected(IHoldingZoneCom com)
    {
        foreach (var data in com.GetIngredients())
        {

            hzc.TryAddIngredient(data);
        }
    }

    private CoffeeData process(List<IngredientData> input)
    {
        foreach(var recipe in allData)
        {
            if (MatchIngredients(recipe.CofeeIngreditens, input)){
                return recipe;
            }
        }
        return null;
    }

    private bool MatchIngredients(IngredientData[] recipeIngredients, List<IngredientData> inputs)
    {
        if (recipeIngredients.Length != inputs.Count)
            return false;

        foreach (var ingredient in recipeIngredients)
        {
            if (!inputs.Contains(ingredient))
                return false;
        }

        return true;
    }

}
