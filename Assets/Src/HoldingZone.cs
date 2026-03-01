
using System.Collections.Generic;
using UnityEngine;

public class HoldingZoneComponent : MonoBehaviour
{
    [SerializeField] private int maxCapacity = 4;

    private List<IngredientData> storedIngeridents = new();
    private CoffeeData storedCoffee = null;

    public bool TryAddIngredient(IngredientData ingredient)
    {
        if (storedIngeridents.Count >= maxCapacity)
            return false;

        storedIngeridents.Add(ingredient);
        Debug.Log($"{ingredient.name} added to {gameObject.name}");
        return true;
    }


    public IngredientData GetIngredient(int index)
    {
        return storedIngeridents[index]; 
    }

    public List<IngredientData> GetIngredients()
    {
        return storedIngeridents;
    }

    public void Clear()
    {
        storedIngeridents.Clear();
    }

    public bool isFull()
    {
        return (storedIngeridents.Count >= maxCapacity || storedCoffee != null) ;
    }

    public CoffeeData GetCoffee()
    {
        return storedCoffee;
    }

    public bool SetCoffee(CoffeeData coffee)
    {
        if (storedCoffee != null)
        {
            return false;
        }
        storedCoffee = coffee;
        return true;
    }
}
