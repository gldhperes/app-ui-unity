using UnityEngine;

[CreateAssetMenu(fileName = "Card", menuName = "ScriptableObjects/Cards", order = 1)]
public class SO_Cards: ScriptableObject
{
    [SerializeField] private Texture card_img; public Texture Card_Img { get { return card_img; } }
    [SerializeField] private Texture card_union_img; public Texture Card_union_img { get { return card_union_img; } }
    [SerializeField] private Texture card_rarity_img; public Texture Card_rarity_img { get { return card_rarity_img; } }
    [SerializeField] private Texture card_info_img; public Texture Card_info_img { get { return card_info_img; } }
    [SerializeField] private Texture card_price_img; public Texture Card_price_img { get { return card_price_img; } }

    // Variável pública para exibir o enum no Inspector
    public Rarities.Rarity rarity;
    
}