using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverSprite : MonoBehaviour
{
    public string nombreJugador;
    public int nroDeClase;
    public float limiteX;
    public bool estaEnMovimiento;
    public float velocidad;

    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Hola " + nombreJugador);
        Debug.Log("Esta es la clase nro: " + nroDeClase);
        Debug.Log("Esta en movimiento: " + estaEnMovimiento);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxis("Horizontal")); 

        if (estaEnMovimiento)
        {
            transform.Translate(velocidad * Input.GetAxis("Horizontal"), velocidad * Input.GetAxis("Vertical"), 0);
        }
    }
}
