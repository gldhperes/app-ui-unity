using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Shop_View : MonoBehaviour
{
    [Header("Manual Config")]
    [SerializeField] private Shop_Modelview shop_Modelview;



    [Header("Auto Config")]
    [SerializeField] private Label shop_label;

    [Header("ScrollView")]
    [SerializeField] private List<ScrollView> items_contents = new List<ScrollView>();
    [SerializeField] private ScrollView cars_content;
    [SerializeField] private ScrollView parts_content;

    [Header("Buttons")]
    [SerializeField] private Button cars_button;
    [SerializeField] private Button parts_button;


    void Start()
    {
        // Acha o UXML do gameobject
        var root = GetComponent<UIDocument>().rootVisualElement;

        // Atribui o main-container
        this.cars_content = root.Q<ScrollView>("cars-content");
        this.parts_content = root.Q<ScrollView>("parts-content");
        items_contents.Add(this.cars_content);
        items_contents.Add(this.parts_content);



        // Atribui shop_label
        this.shop_label = root.Q<Label>("label-text");

        // Atribui o parts-button
        this.parts_button = root.Q<Button>("parts-btn");
        this.parts_button.RegisterCallback<ClickEvent>(On_Parts_Button_Click);

        // Atribui o cars-button
        this.cars_button = root.Q<Button>("cars-btn");
        this.cars_button.RegisterCallback<ClickEvent>(On_Cars_Button_Click);
        

        // SET ACTIVE BUTTON
        this.Set_Active_Button(this.cars_button);
        this.Change_Content(this.cars_content);

        // SET ITEMS
        this.Set_Cars();
        this.Set_Parts();

    }

    private void On_Parts_Button_Click(ClickEvent evt)
    {
        this.Set_Active_Button(this.parts_button);

        this.Change_Content(this.parts_content);
    }
    private void On_Cars_Button_Click(ClickEvent evt)
    {
        this.Set_Active_Button(this.cars_button);

        this.Change_Content(this.cars_content);
    }

    private void Set_Active_Button(Button button)
    {
        // ATIVA O BOTAO PRINCIPAL
        button.Focus();

        // COLOCA O TEXTO DO BOTAO PRINCIPAL NO LABEL DA LOJA
        this.Change_Shop_Label_Text(button.text);
    }




    // MUDAR O CONTENT PARA O TIPO DO BOTAO
    private void Change_Content(VisualElement content)
    {

        foreach (VisualElement item in items_contents)
        {
            if (item == content)
            {
                content.style.display = DisplayStyle.Flex;
            }
            else
            {
                item.style.display = DisplayStyle.None;
            }

        }
    }


    // COLOCA O TEXTO DO BOTAO PRINCIPAL NO LABEL DA LOJA
    private void Change_Shop_Label_Text(string txt)
    {
        string label_text = txt;
        this.shop_label.text = label_text;
    }




    #region ITENS

    private void Set_Cars()
    {

        List<VisualElement> car_cards = this.shop_Modelview.Set_Cars();

        foreach (VisualElement car in car_cards)
        {
            this.cars_content.Add(car);
        }

    }

    private void Set_Parts()
    {
        List<VisualElement> parts_cards = this.shop_Modelview.Set_Parts();

        foreach (VisualElement item in parts_cards)
        {
            parts_content.Add(item);
        }
    }

    #endregion ITENS

}
