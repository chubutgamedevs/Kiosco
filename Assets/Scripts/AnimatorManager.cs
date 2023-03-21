using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AnimatorManager : MonoBehaviour
{
    [SerializeField] Transform globoImg;
    [SerializeField] Transform llevo;
    [SerializeField] Vector3 tamanio = new Vector3(1f, 1f, 1f);
    [SerializeField] Vector3 aLlevar = new Vector3(1.5f, 1.5f, 1.5f);
    [SerializeField] GameObject botonVuelto;
    [SerializeField] float lugarBoton = 0;






    void Awake()
    {
        DOTween.Init();
        globoImg.transform.DOScale(tamanio, 1);
        llevo.transform.DOScale(aLlevar, 1);
        llevo.transform.DOMoveY(2f, 1);

        botonVuelto.transform.DOMoveY(lugarBoton, 1);

    }
}