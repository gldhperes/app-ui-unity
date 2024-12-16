using System.Collections.Generic;
using Unity.AppUI.UI;
using UnityEngine;
using UnityEngine.UIElements;

public class Shop_Model : MonoBehaviour
{

    [Header("Resources")]
    [SerializeField] private VisualTreeAsset cards_template;

    [Header("Components List")]
    [SerializeField] private List<ScriptableObject> cars;
    [SerializeField] private List<ScriptableObject> currency;
    [SerializeField] private List<ScriptableObject> parts;



    #region CAR CARDS

    public List<VisualElement> Get_Car_Cards()
    {
    
        List<VisualElement> cards = new List<VisualElement>();
        foreach (SO_Cars car in cars)
        {
            cards.Add(this.Bake_Car_Card(car));
        }

        return cards;


    }

    private VisualElement Bake_Car_Card(SO_Cars car)
    {
        // Faz o clonagem do Card_Template , chamando o ID do root do Objeto
        VisualElement new_card = cards_template.CloneTree().Q<VisualElement>("card-root");

        // Lugar do Card
        this.Set_Card(new_card, car.Card_Img);

        // Lugar do Carro
        this.Set_Item(new_card, car.Car_img);

        // Lugar do Union
        this.Set_Union(new_card, car.Card_union_img);

        // Lugar do Raridade
        this.Set_Rarity(new_card, car.Card_rarity_img);

        // Lugar do Info
        this.Set_Info(new_card, car.Card_info_img);

        // Lugar do Union
        this.Set_Buy_Btn(new_card, car.Card_price_img);

        return new_card;
    }

    private void Set_Card(VisualElement new_card, Texture card_img)
    {
        VisualElement card_content = new_card.Q<VisualElement>("card-content");
        card_content.style.backgroundImage = (StyleBackground)card_img;
    }

    private void Set_Item(VisualElement new_card, Texture item_img)
    {
        Unity.AppUI.UI.Avatar item_image = new_card.Q<Unity.AppUI.UI.Avatar>("item-image");
        item_image.style.backgroundImage = (StyleBackground)item_img;
    }

    private void Set_Union(VisualElement new_card, Texture union)
    {
        Unity.AppUI.UI.Icon item_image = new_card.Q<Unity.AppUI.UI.Icon>("union");
        item_image.style.backgroundImage = (StyleBackground)union;
    }

    private void Set_Rarity(VisualElement new_card, Texture rarity)
    {
        Unity.AppUI.UI.Avatar item_image = new_card.Q<Unity.AppUI.UI.Avatar>("rarity");
        item_image.style.backgroundImage = (StyleBackground)rarity;
    }

    private void Set_Info(VisualElement new_card, Texture info)
    {
        Unity.AppUI.UI.Avatar item_image = new_card.Q<Unity.AppUI.UI.Avatar>("info");
        item_image.style.backgroundImage = (StyleBackground)info;
    }

    private void Set_Buy_Btn(VisualElement new_card, Texture buy_Btn)
    {
        Unity.AppUI.UI.Button item_image = new_card.Q<Unity.AppUI.UI.Button>("buy-button");
        item_image.style.backgroundImage = (StyleBackground)buy_Btn;
    }

    #endregion CAR CARDS





    #region CURRENCY CARDS

    public List<VisualElement> Get_Currency_Cards()
    {
     
        List<VisualElement> cards = new List<VisualElement>();

        foreach (SO_Currency cur in currency)
        {
            cards.Add(this.Bake_Currency_Card(cur));
        }

        return cards;

    }

    private VisualElement Bake_Currency_Card(SO_Currency cur)
    {
        // Faz o clonagem do Card_Template , chamando o ID do root do Objeto
        VisualElement new_card = cards_template.CloneTree().Q<VisualElement>("card-root");

        // Lugar do Currency
        this.Set_Item(new_card, cur.Currency_img);

        // Lugar do Card
        this.Set_Card(new_card, cur.Card_Img);

        // Lugar do Union
        this.Set_Union(new_card, cur.Card_union_img);

        // // Lugar do Union
        this.Set_Buy_Btn(new_card, cur.Card_price_img);

        return new_card;
    } 

    #endregion CURRENCY CARDS
}
