using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VueltoManager : MonoBehaviour
{

    [SerializeField] CompraNpc elVuelto;
    int sumabilletes;

    #region eventos
    void OnEnable()
    {
        EventManager.OnBilleteLLevadoAVuelto += AcumularVuelto;
        EventManager.OnBilleteQuitadoDeVuelto += DesAcumularVuelto;

    }

    void OnDisable()
    {
        EventManager.OnBilleteLLevadoAVuelto -= AcumularVuelto;
        EventManager.OnBilleteQuitadoDeVuelto -= DesAcumularVuelto;

    }


    #endregion

    public void AcumularVuelto(List<Billete> Listbilletes)
    {
        
        foreach (var b in Listbilletes)
        {
            sumabilletes += b.valor;
            Debug.Log(sumabilletes);
        }
        if (sumabilletes == elVuelto.vuelto)
        {   

            Debug.Log("vueltoCorrecto");
        }
        else
        {
            Debug.Log("No es el vuelto");
        }

    }
    public void DesAcumularVuelto(Billete billete)
    {
        sumabilletes -= billete.valor;
    }

    void Start()
    {

    }


}
