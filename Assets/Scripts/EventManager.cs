using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static event System.Action<string> OnBilleteClikeado = delegate { };
    public static void ClikearBillete(string billete)
    {
        OnBilleteClikeado(billete);
    }
}
