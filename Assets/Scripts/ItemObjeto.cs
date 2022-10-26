using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObjeto : MonoBehaviour
{
    public ItemData itemData;

    public void AgregarObjetos()
    {
        StackKiosco.Instance.Add(itemData);
    }
    private void Awake()
    {
        AgregarObjetos();
    }


}
