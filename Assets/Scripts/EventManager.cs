using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    #region eventos de billete
    public static event System.Action<string> OnBilleteClikeado = delegate { };
    public static event System.Action<Billete> OnBilleteLLevadoAVuelto = delegate { };
    #endregion

    public static void ClikearBillete(string billete)
    {
        OnBilleteClikeado(billete);
    }

    public static void LlevarBilleteAVuelto(Billete billete)
    {
        OnBilleteLLevadoAVuelto(billete);
    }
}
