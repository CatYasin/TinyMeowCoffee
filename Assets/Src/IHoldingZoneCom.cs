using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public interface IHoldingZoneCom
{
    public List<IngredientData> GetIngredients();
    public bool SetCoffee(CoffeeData coffee);

}
