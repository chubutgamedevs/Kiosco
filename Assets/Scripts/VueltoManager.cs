using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class VueltoManager : MonoBehaviour
{

    [SerializeField] CompraNpc elVuelto;
    // [SerializeField] Transform losBilletes;
    int sumabilletes;

    public List<Billete> vueltoEnLista;
    #region eventos
    void OnEnable()
    {
        EventManager.OnBilleteLLevadoAVuelto += AcumularVuelto;
        EventManager.OnBilleteQuitadoDeVuelto += DesAcumularVuelto;
        EventManager.OnEntregarVuelto += EntregarVueltoCliente;
    }

    void OnDisable()
    {
        EventManager.OnBilleteLLevadoAVuelto -= AcumularVuelto;
        EventManager.OnBilleteQuitadoDeVuelto -= DesAcumularVuelto;
        EventManager.OnEntregarVuelto -= EntregarVueltoCliente;
    }


    #endregion

    public void AcumularVuelto(List<Billete> Listbilletes)
    {

        foreach (var b in Listbilletes)
        {
            sumabilletes += b.valor;
            //Debug.Log(b);
            Debug.Log(sumabilletes);
            vueltoEnLista.Add(b);
        }
        if (sumabilletes == elVuelto.vuelto)
        {
            //Comunicar al cliente que el vuelto esta bien o mal
            //como Pista se podria lanzar el cartel de entregar vuelto en este momento
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
        Debug.Log(sumabilletes);
    }

    public void EntregarVueltoCliente(Billete vuelto)
    {
        //desde aqui hacer las animaciones de entregar el vuelto , ya que aqui esta la lista de billetes a entregar
        Debug.Log("aaaa");

    }
    //como en vuelto se esstan clonando los billetes necesito obtener los chills de vuelto
    //hay que hacer referencia del vuelto y hacer un getchilld


}
