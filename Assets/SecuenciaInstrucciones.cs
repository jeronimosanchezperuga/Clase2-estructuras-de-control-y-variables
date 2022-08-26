using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecuenciaInstrucciones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Esto es un mensaje");
        Debug.Log("Esto es otro mensaje");
        Debug.Log("Esto es un tercer mensaje");

        Debug.Log(2022 + 99);
        Debug.Log(10.0 / 3);
        Debug.Log(4*3);

        //Contatenación
        Debug.Log(2022 + "a");
        Debug.Log("Hola " + "hoy es " + (25 + 3) + " de agosto") ;

        //Comparación
        Debug.Log("2022 es menor o igual que 2022" + (2022 <= 2022));

        //Operadores lógicos
        Debug.Log(3 > 1 && 2==3 || 4>2 || 2==1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
