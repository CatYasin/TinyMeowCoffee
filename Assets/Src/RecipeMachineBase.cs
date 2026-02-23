using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class RecipeMachineBase : MonoBehaviour
{
    [SerializeField] protected MachineTypes machineType;
    [SerializeField] protected List<IngeridenrsRecipeData> allRecipes;

    protected IngredientData Process(List<IngredientData> inputs)
    {
        foreach (var recipe in allRecipes)
        {
            if (recipe.isRequiedType && recipe.requiedType != machineType)
                continue;

            if (MatchIngredients(recipe.input, inputs))
            {
                return recipe.output;
            }
        }

        return null;
    }

    protected bool MatchIngredients(IngredientData[] recipeIngredients, List<IngredientData> inputs)
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
