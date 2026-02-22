using UnityEngine;



[CreateAssetMenu(menuName = "Coffee/Ingredient")]
public class IngredientData : ScriptableObject
{
    public string ingredientName;
    public Sprite icon;

    public bool canBeHeated;
    public IngredientData heatedVersion;

    public bool canBeWhipped;
    public IngredientData whippedVersion;


}