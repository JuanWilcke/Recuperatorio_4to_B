using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consigna : MonoBehaviour
{
    public int edad;
    public float altura;
    // Start is called before the first frame update
    void Start()
    {
        if (edad<13 || altura<1.2)
        {
            Debug.Log("Acceso denegado");
        }
        else if (edad >= 13 || altura >= 1.2)
        {
            Debug.Log("Acceso permitido");
        }
        else if (edad < 1 || altura < 0)
        {
            Debug.Log("Error");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
