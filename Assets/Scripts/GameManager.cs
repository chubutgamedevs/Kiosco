using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    CompraNpc clienteActual;

    [SerializeField] GameObject npcs;
    private List<NPCGenerator> _npcs;

    #region eventos
    void OnEnable()
    {

        EventManager.OnLLegaCliente += HandleClienteNew;
        EventManager.OnObjetoDropeado += HandleObjetoDrop;
    }

    void OnDisable()
    {
        EventManager.OnLLegaCliente -= HandleClienteNew;
        EventManager.OnObjetoDropeado -= HandleObjetoDrop;
    }


    #endregion

    private void Awake()
    {

        // _npcs = new List<NPCGenerator>(npcs.GetComponentsInChildren<NPCGenerator>());
        // Debug.Log("Wumpuses recolectados" + _npcs.Count);
    }
    // public void GenerateNPCs() => _npcs.ForEach(npc => npc.Generate());

    public void Variantes()
    {
        _npcs[0].Generate();

        for (int i = 1; i < _npcs.Count; i++)
        {
            _npcs[i].Clonate(_npcs[0]);
            _npcs[i].Mutate(i);
        }
    }




    public void HandleClienteNew(CompraNpc cliente)
    {
        Debug.Log("ClienteActual");
        clienteActual = cliente;
    }



    public void HandleObjetoDrop(GameObject objItem)
    {
        ItemData item = objItem.GetComponent<ItemObjeto>().itemData;
        if (item.itemNombre == clienteActual.item.data.itemNombre)
        {
            Debug.Log("Si es");
            clienteActual.Pagar();
            clienteActual.llevo(objItem);
        }

    }

    public void VerifiVuelto()
    {



    }


}
