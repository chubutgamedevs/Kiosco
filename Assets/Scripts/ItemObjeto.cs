using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemObjeto : MonoBehaviour
{
    public ItemData itemData;
    [SerializeField] private TextMeshPro itemPrecio;
    public void AgregarObjetos()
    {
        StackKiosco.Instance.Add(itemData);
    }
    private void Start()
    {
        itemPrecio.text = string.Join(" ", itemData.precio);
        GetComponent<SpriteRenderer>().sprite = itemData.icon;

        AgregarObjetos();
    }


}
