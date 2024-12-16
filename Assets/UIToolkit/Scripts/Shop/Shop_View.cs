using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Shop_View : MonoBehaviour
{
    [Header("Auto Config")]
    [SerializeField] private VisualElement main_content;



    void Start()
    {
        // Acha o UXML do gameobject
        var root = GetComponent<UIDocument>().rootVisualElement;

        // Atribui o main-container
        this.main_content = root.Q<VisualElement>("main-content");

        // this.Set_Offers();


        // this.Set_Parts();
        this.Set_Currency();
        this.Set_Cars();
    }


    private void Set_Cars()
    {
        Shop_Model shop_Model = GetComponent<Shop_Model>();
        List<VisualElement> car_cards = shop_Model.Get_Car_Cards();

        foreach (VisualElement car in car_cards)
        {
            main_content.Add(car);
        }
    }

    private void Set_Currency()
    {

        Shop_Model shop_Model = GetComponent<Shop_Model>();
        List<VisualElement> currency_cards = shop_Model.Get_Currency_Cards();

        foreach (VisualElement item in currency_cards)
        {
            main_content.Add(item);
        }

    }


    private void Set_Parts()
    { }


    private void Set_Offers()
    { }



}
