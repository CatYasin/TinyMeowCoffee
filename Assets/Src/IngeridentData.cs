using UnityEngine;



[CreateAssetMenu(menuName = "Coffee/Ingredient")]
public class IngredientData : ScriptableObject
{
    public string ingredientName;
    public Sprite icon;
    public Sprite sprite;

    public MachineTransformation[] transformations;
}

[System.Serializable]
public class MachineTransformation
{
    public MachineTypes machineType;
    public IngredientData result;
}