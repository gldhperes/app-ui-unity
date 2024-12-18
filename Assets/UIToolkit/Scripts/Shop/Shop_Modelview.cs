using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Shop_Modelview : MonoBehaviour
{

    [Header("Manual Config")]
    [SerializeField] private Shop_Model shop_model;

    public List<VisualElement> Set_Cars()
    {
        List<VisualElement> cards = shop_model.Get_Car_Cards();
        return cards;
    }

    public List<VisualElement> Set_Parts()
    {
        List<VisualElement> cards = shop_model.Get_Parts_Cards();
        return cards;
    }


}
