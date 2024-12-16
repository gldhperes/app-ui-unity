using UnityEngine;

[CreateAssetMenu(fileName = "Currency", menuName = "ScriptableObjects/Currency", order = 4)]
public class SO_Currency : ScriptableObject
{
    [SerializeField] private Texture currency_img; public Texture Currency_img { get { return currency_img; } }
    [SerializeField] private Texture card_img; public Texture Card_Img { get { return card_img; } }
    [SerializeField] private Texture card_union_img; public Texture Card_union_img { get { return card_union_img; } }
    [SerializeField] private Texture card_price_img; public Texture Card_price_img { get { return card_price_img; } }

}
