using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinoPosicionManager : MonoBehaviour
{
    Vector3 posicionInicial;

    float xOffset = 0.3f;
    float yOffset = 0.5f;

    int cantBilletesPorFila = 10;
    int cantBilletesActual = 0;


    #region eventos
    private void OnEnable()
    {
        EventManager.OnBilleteClikeado += nuevaPosicion;
    }
    private void OnDisable()
    {
        EventManager.OnBilleteClikeado -= nuevaPosicion;
    }
    #endregion eventos  

    #region ciclo de vida

    void Start()
    {
        posicionInicial = transform.position;
    }

    #endregion

    #region metodos

    private void nuevaPosicion(string unused)
    {
        cantBilletesActual++;

        float xBillete = (cantBilletesActual % cantBilletesPorFila) * xOffset;
        float yBillete = Mathf.Round(cantBilletesActual / cantBilletesPorFila) * yOffset;
        float ZBillete = -(xBillete + yBillete * 2) / 10;

        Vector3 nuevaPosicion = posicionInicial + new Vector3(xBillete, yBillete, ZBillete);
        this.transform.position = nuevaPosicion;
    }

    #endregion
}
