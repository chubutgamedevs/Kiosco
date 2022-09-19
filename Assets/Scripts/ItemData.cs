
using UnityEngine;
[CreateAssetMenu(fileName = "Item Datos", menuName = "Inventory System/Create Item", order = 0)]
public class ItemData : ScriptableObject
{
    public string id;
    public string itemNombre;
    public int precio;
    public Sprite icon;
    public GameObject itemPrefab;
}
