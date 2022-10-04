using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackKiosco : MonoBehaviour
{
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
            Debug.Log("agrego nuevo item");
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
    public List<int> dineroInicial = new List<int>
    {20,50,100,200,500,1000};
    List<int> ObternerDinero(List<int> DineroRandom, int count)
    {
        List<int> caja = new List<int>();
        for (int i = 0; i < count; i++)
        {
            int indiceRandom = Random.Range(0, DineroRandom.Count);
            caja.Add(DineroRandom[indiceRandom]);
        }
        return caja;
    }
    private void Start()
    {
        var cajaDelDia = ObternerDinero(dineroInicial, 15);
        Debug.Log(string.Join(" ,", cajaDelDia));
    }

}
