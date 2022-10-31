using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Billete : MonoBehaviour
{

    [SerializeField] Transform destino;
    [SerializeField] Transform vuelto;
    public Transform move;
    bool original = true;
    void Start()
    {

    }
    private void OnMouseDown()
    {

        if (original)
        {
            GameObject b = Instantiate(gameObject, vuelto);
            b.GetComponent<Billete>().original = false;
            b.GetComponent<Billete>().destino = transform;
            b.transform.DOMove(destino.position, 1f);

            //vuelto.position = new Vector3(1f, 1f, 1f);
        }
        else
        {
            transform.DOMove(destino.position, 1f).OnComplete(() => Destroy(this.gameObject));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
