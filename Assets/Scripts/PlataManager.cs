using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlataManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject moldeBillete;
    [SerializeField] List<Sprite> imgBillete;

    [SerializeField] Vector3 offsetDelta = new Vector3(3f, -0.5f, -0.1f);

    public static int valorToIndice(int valor)
    {
        switch (valor)
        {
            case 1: return 0;
            case 2: return 1;
            case 5: return 2;
            case 10: return 3;
            case 20: return 4;
            case 50: return 5;
            case 100: return 6;
            default: return -1;
        }
    }

    public void DarVuelto(List<int> vuelto)
    {
        Vector3 offset = Vector3.zero;

        Sequence s = DOTween.Sequence();
        foreach (var billete in vuelto)
        {
            GameObject b = Instantiate(moldeBillete, transform);
            b.GetComponent<SpriteRenderer>().sprite = imgBillete[PlataManager.valorToIndice(billete)];
            s.Append(b.transform.DOMove(offset, 1f));
            offset += offsetDelta;
        }
    }


}
