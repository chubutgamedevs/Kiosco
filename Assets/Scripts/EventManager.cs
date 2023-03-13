using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    #region eventos de billete
    public static event System.Action<string> OnBilleteClikeado = delegate { };
    public static event System.Action<List<Billete>> OnBilleteLLevadoAVuelto = delegate { };
    public static event System.Action<GameObject> OnObjetoDropeado = delegate { };
    public static event System.Action<CompraNpc> OnLLegaCliente = delegate { };
    public static event System.Action<Billete> OnBilleteQuitadoDeVuelto = delegate { };
    public static event System.Action<List<Billete>> OnEntregarVuelto = delegate { };

    #endregion

    public static void ClikearBillete(string billete)
    {
        // Debug.Log("ClikearBillete");
        OnBilleteClikeado(billete);
    }

    public static void ObjetoDropeado(GameObject item)
    {
        //Debug.Log("objetoDRopeado");
        OnObjetoDropeado(item.gameObject);

    }
    public static void LLegaCliente(CompraNpc cliente)
    {
        //Debug.Log("LLegaCliente");
        OnLLegaCliente(cliente);
    }
    public static void BilleteQuitadoDeVuelto(Billete billete)
    {
        OnBilleteQuitadoDeVuelto(billete);
    }
    public static void LlevarBilleteAVuelto(List<Billete> Listbilletes)
    {
        // Debug.Log("LlevarBilleteAVuelto");
        OnBilleteLLevadoAVuelto(Listbilletes);
    }
    public static void EntregarVuelto(List<Billete> billetes)
    {
        OnEntregarVuelto(billetes);
    }
}
