using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class VerificarItem : MonoBehaviour
{
    private GameObject controlador;
    [SerializeField] VueltoManager list;
    [SerializeField] float movX = 0;
    [SerializeField] float timeX = 0;
    [SerializeField] float movY = 0;
    [SerializeField] float timeY = 0;
    [SerializeField] float timeDestroy = 0;


    private void UsarLista(List<Billete> listBillete)
    {

        foreach (var item in listBillete)
        {
            item.transform.DOMoveY(movX, timeX);
            item.transform.DOMoveX(movY, timeY);
            Destroy(item.gameObject, timeDestroy);
        }

    }

    private void OnMouseDown()
    {
        UsarLista(list.vueltoEnLista);

    }

}
