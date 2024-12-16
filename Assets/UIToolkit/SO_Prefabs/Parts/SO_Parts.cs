using UnityEngine;

[CreateAssetMenu(fileName = "Parts", menuName = "ScriptableObjects/Parts", order = 3)]
public class SO_Parts : ScriptableObject
{
    [SerializeField] private Texture parts_img; public Texture Parts_img { get { return parts_img; } }
    [SerializeField] private Texture card_img; public Texture Card_Img { get { return card_img; } }
    [SerializeField] private Texture card_union_img; public Texture Card_union_img { get { return card_union_img; } }
    [SerializeField] private Texture card_rarity_img; public Texture Card_rarity_img { get { return card_rarity_img; } }
    [SerializeField] private Texture card_info_img; public Texture Card_info_img { get { return card_info_img; } }
    [SerializeField] private Texture card_price_img; public Texture Card_price_img { get { return card_price_img; } }

}
