using UnityEngine;
using UnityEngine.UIElements;

public class Shop_View: MonoBehaviour
{
    [Header("Auto Config")]
    [SerializeField] private VisualElement main_container;

    void Start()
    {
        // Acha o UXML do gameobject
        var root = GetComponent<UIDocument>().rootVisualElement;

        // Atribui o main-container
        this.main_container = root.Q<VisualElement>("main-container");
    
    }


    public void Show_Itens()
    {
        
    }


}
