using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consigna_helado : MonoBehaviour
{
    public int cantidad;
    public string sabor;
    int precio;
    // Start is called before the first frame update
    void Start()
    {
        precio = cantidad%2;
        if (cantidad > 250 || cantidad <3000)
        {
            Debug.Log("Error, las cantidades no son validas ");
        }
        if (cantidad <= 250 || cantidad >= 3000 && sabor == "CHO" && sabor == "DDL")
        {
            Debug.Log("El precio es de " + precio);
        }
        else if (sabor == "FRU")
        {
            Debug.Log("El precio es de" + precio*0.10);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
