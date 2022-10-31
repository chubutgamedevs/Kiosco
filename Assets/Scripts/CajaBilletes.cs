using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajaBilletes : MonoBehaviour
{
    [SerializeField] GameObject destino;
    [SerializeField] GameObject billete;
    // Start is called before the first frame update
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(destino.transform.position, 1f);
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }







}
