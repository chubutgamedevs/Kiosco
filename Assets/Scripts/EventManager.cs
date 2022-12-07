using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    #region eventos de billete
    public static event System.Action<string> OnBilleteClikeado = delegate { };
    public static event System.Action<Billete> OnBilleteLLevadoAVuelto = delegate { };
    public static event System.Action<GameObject> OnObjetoDropeado = delegate { };
    public static event System.Action<CompraNpc> OnLLegaCliente = delegate { };
    //public static event System.Action<CompraNpc> OnLLegaCliente = delegate { };

    #endregion

    public static void ClikearBillete(string billete)
    {
        // Debug.Log("ClikearBillete");
        OnBilleteClikeado(billete);
    }

    public static void LlevarBilleteAVuelto(Billete billete)
    {
        // Debug.Log("LlevarBilleteAVuelto");
        OnBilleteLLevadoAVuelto(billete);
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
}
