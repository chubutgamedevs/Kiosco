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
    public int valor;
    //public List<Billete> vueltoE = new List<Billete>();
    private void OnMouseDown()
    {
        AnunciarBilleteClickeado();

        if (original)
        {
            GameObject b = Instantiate(gameObject, vuelto);
            Billete bi = b.GetComponent<Billete>();
            bi.original = false;
            bi.destino = transform;
            b.transform.DOMove(destino.position, Constantes.tiempoDeIdaBillete).OnComplete(AnunciarBilleteLLegoAVuelto);

            List<Billete> v = new List<Billete>();
            v.Add(bi);
            EventManager.LlevarBilleteAVuelto(v);
        }
        else
        {
            EventManager.BilleteQuitadoDeVuelto(this);
            transform.DOMove(destino.position, 1f).OnComplete(() => Destroy(this.gameObject));

        }
    }

    public void AnunciarBilleteLLegoAVuelto()
    {
        // List<Billete> vuelto = new List<Billete>();
        // vuelto.Add(this);
        // EventManager.LlevarBilleteAVuelto(vuelto);
    }

    private void AnunciarBilleteClickeado()
    {
        EventManager.ClikearBillete(this.tag);
    }

    public void BilletesJuntadosAEntregar()
    {
        //quiero recibir la lista ya conformada

        //EventManager.EntregarVuelto(this);

    }



    private void Awake()
    {
        valor = int.Parse(tag.Split("_")[1]);
        Debug.Log(valor);
    }


}
