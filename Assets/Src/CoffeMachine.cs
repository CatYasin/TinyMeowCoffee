
using System.Collections.Generic;
using UnityEngine;

public class CoffeMachine : MonoBehaviour
{
    
    [SerializeField] private CoffeeData[] allData;

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
