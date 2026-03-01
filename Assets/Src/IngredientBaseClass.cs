using UnityEngine;

public class IngredientBaseClass : MonoBehaviour, IPickup
{
    [SerializeField] private IngredientData _data;

    SpriteRenderer sr;

    

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = _data.sprite;
    }

    public IngredientData GetItem()
    {
        Destroy(gameObject);
        Debug.Log("LastTryOHH");
        return _data;
    }

}
