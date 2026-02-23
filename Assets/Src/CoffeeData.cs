
using UnityEngine;

[CreateAssetMenu(menuName = "Coffee/Coffee Data")]
public class CoffeeData : ScriptableObject
{
    public string Name;
    public float price;
    public Sprite icon;

    
    public IngredientData[] CofeeIngreditens;


};
