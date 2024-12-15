using UnityEngine;

[CreateAssetMenu(fileName = "Car", menuName = "ScriptableObjects/Cars", order = 1)]
public class SO_Cars: ScriptableObject
{
    [SerializeField] private Texture item_img;

    // Variável pública para exibir o enum no Inspector
    public Rarities.Rarity raridade;

    
}