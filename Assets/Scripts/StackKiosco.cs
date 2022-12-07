using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackKiosco : MonoBehaviour
{
    [SerializeField] PlataManager caja;
    public Dictionary<ItemData, InventoryItem> _itemDictionary;
    public List<InventoryItem> inventKiosco;
    public static StackKiosco Instance;



    private void Awake()
    {
        inventKiosco = new List<InventoryItem>();
        _itemDictionary = new Dictionary<ItemData, InventoryItem>();
        Instance = this;
    }
    //Metodo que agrega el item al invenatario del kiosco
    public void Add(ItemData itemData)
    {
        //Veo si el item esta en el invetario y lo sumo al stack
        if (_itemDictionary.TryGetValue(itemData, out InventoryItem value))
        {
            Debug.Log("sumando item al stack");
            value.AddStack();
        }
        else //agrego el item al stack en caso de que no este
        {
            //            Debug.Log("agrego nuevo item");
            InventoryItem newItem = new InventoryItem(itemData);
            inventKiosco.Add(newItem);
            _itemDictionary.Add(itemData, newItem);
        }
    }
    //Remuevo el item que se acabo en el stack 
    public void Remove(ItemData itemData)
    {
        if (_itemDictionary.TryGetValue(itemData, out InventoryItem value))
        {
            value.RemoveFromStack();
            if (value.stackSize == 0)
            {
                inventKiosco.Remove(value);
                _itemDictionary.Remove(itemData);
            }
        }
    }
    private void Start()
    {

    }

}
