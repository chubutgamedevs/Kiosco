using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompraNpc : MonoBehaviour
{

    private List<int> ListDinero = new List<int>
    {20,50,100,200,500,1000};
    List<int> ObternerDinero(List<int> DineroRandom, int count)
    {
        List<int> billetera = new List<int>();
        for (int i = 0; i < count; i++)
        {
            int indiceRandom = Random.Range(0, DineroRandom.Count);
            billetera.Add(DineroRandom[indiceRandom]);
        }
        return billetera;
    }



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            var plataRandom = ObternerDinero(ListDinero, 4);
            Debug.Log(string.Join(" ,", plataRandom));
        }
    }
}
