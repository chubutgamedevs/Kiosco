using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class AnimationGlob : MonoBehaviour
{

    [SerializeField] Transform globoImg;
    [SerializeField] Vector3 tamanio = new Vector3(1f, 1f, 1f);


    void Awake()
    {
        DOTween.Init();
        transform.DOScale(tamanio, 1);


    }


}
