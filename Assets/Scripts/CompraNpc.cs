using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using DG.Tweening;

public class CompraNpc : MonoBehaviour
{
    [SerializeField] PlataManager pm;

    private List<int> BilleteraRandom;
    public int totalBilletera;
    public int valorPre;
    public int vuelto;
    
    public InventoryItem item;
    [SerializeField] SpriteRenderer globoImg;
    [SerializeField] Vector3 destino = new Vector3(0f, 0f, 0f);
    //public List<InventoryItem> estante;
    private List<int> ListDinero = new List<int>
    {1,2,5,10,20,50,100};
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
    List<InventoryItem> QuieroItem(List<InventoryItem> itemRandom, int count)
    {
        List<InventoryItem> llevar = new List<InventoryItem>();
       
        for (int i = 0; i < count; i++)
        {
            int indiceRnd = Random.Range(0, itemRandom.Count);
            llevar.Add(itemRandom[indiceRnd]);
        }
        return llevar;
    }
    public int ObtenerVuelto(int valorPre, List<int> pago)
    {
        int totalPago = 0;
        for (int i = 0; i < pago.Count; i++)
        {
            totalPago += pago[i];
        }

        return totalPago - valorPre;

    }
    public List<int> ListPagar(int precio)
    {
        BilleteraRandom = BilleteraRandom.OrderByDescending(x => x).ToList(); ;
        Debug.Log(string.Join(" ", BilleteraRandom));
        int pagado = 0;
        List<int> pago = new List<int>();
        while (pagado < precio || BilleteraRandom.Count == 0)
        {
            pagado += BilleteraRandom[0];
            pago.Add(BilleteraRandom[0]);
            BilleteraRandom.RemoveAt(0);
        }
        return pago;
    }
    public void Pedir()
    {
        var newitem = QuieroItem(StackKiosco.Instance.inventKiosco, 1);
        string s = "";
        string p = "";
        item = newitem[0];

        s = string.Join(" ", item.data.itemNombre);
        p = string.Join(" ", item.data.precio);
        valorPre = item.data.precio;
        globoImg.sprite = item.data.icon;


        Debug.Log(string.Join("", " voy a llevar ", s, " Precio ", p));
        Debug.Log(string.Join(" ", "Billetera Npc "));
        BilleteraRandom = ObternerDinero(ListDinero, 4);
        Debug.Log(string.Join(",", BilleteraRandom));
        //Dinero en total que tiene el NPC en la billetera
        for (int i = 0; i < BilleteraRandom.Count; i++)
        {
            totalBilletera += BilleteraRandom[i];
        }

        List<int> pago = ListPagar(valorPre);

        EventManager.LLegaCliente(this);
    }

    public void Pagar()
    {
        List<int> pago = ListPagar(valorPre);

        //El NPC sabe el dinero que tiene que recibir como vuelto 
        vuelto = ObtenerVuelto(valorPre, pago);
        pm.DarPago(pago);
        Debug.Log(string.Join(" ", vuelto, "Este Es el vuelto"));

    }

    public void llevo(GameObject item)
    {
        Destroy(item.gameObject);
    }


    private void Start()
    {
        Pedir();
    }






}
