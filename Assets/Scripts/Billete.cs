using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Constantes
{
    public static float tiempoDeIdaBillete = 1f;
}
public class Billete : MonoBehaviour
{

    [SerializeField] Transform destino;
    [SerializeField] Transform vuelto;
    public Transform move;
    bool original = true;

    private void OnMouseDown()
    {
        AnunciarBilleteClickeado();

        if (original)
        {
            GameObject b = Instantiate(gameObject, vuelto);
            b.GetComponent<Billete>().original = false;
            b.GetComponent<Billete>().destino = transform;
            b.transform.DOMove(destino.position, Constantes.tiempoDeIdaBillete).OnComplete(AnunciarBilleteLLegoAVuelto);

        }
        else
        {
            transform.DOMove(destino.position, 1f).OnComplete(() => Destroy(this.gameObject));
        }
    }

    private void AnunciarBilleteLLegoAVuelto()
    {
        EventManager.LlevarBilleteAVuelto(this);
    }

    private void AnunciarBilleteClickeado()
    {
        EventManager.ClikearBillete(this.tag);
    }


}
