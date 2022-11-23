using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemObjeto : MonoBehaviour
{
    public ItemData itemData;
    public GameObject itemPrecio;
    public void AgregarObjetos()
    {
        StackKiosco.Instance.Add(itemData);
    }
    private void Start()
    {
        AgregarObjetos();
        string s = string.Join(" ", itemData.precio);
        GetComponentInChildren<TextMeshPro>().text = s;
    }


}
