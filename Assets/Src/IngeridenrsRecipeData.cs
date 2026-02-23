using UnityEngine;

[CreateAssetMenu(fileName = "IngeridenrsRecipeData", menuName = "Coffee/IngeridenrsRecipe")]
public class IngeridenrsRecipeData : ScriptableObject
{

    public IngredientData[] input;
    public bool isRequiedType = true;
    public MachineTypes requiedType;
    public IngredientData output;

}
