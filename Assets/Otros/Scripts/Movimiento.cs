using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    //Establecemos la velocidad de giro.
    public float velocidadDeGiro = 100f;  
    //Establecemos la velocidad de movimiento.
    public float velocidadDeMovimiento = 5f;    

    private CharacterController ControlPersonaje;

    void Start()
    {
        //Obtenemos el CharacterController.
        ControlPersonaje = GetComponent<CharacterController>(); 
    }

    void Update()
    {
        //Obtemos los valores de desplazamiento y giro.
        float giroHorizontal = Input.GetAxis("Horizontal");
        float desplazamientoVertical = Input.GetAxis("Vertical");

        //Establecemos el giro del personaje.
        float giro = giroHorizontal * velocidadDeGiro * Time.deltaTime;
        transform.Rotate(0, giro, 0);  // Gira el personaje

        //Establecemos el movimiento del personaje.
        Vector3 direccionDeMovimiento = transform.forward * -desplazamientoVertical * velocidadDeMovimiento * Time.deltaTime;

        //Aplicamos el movimiento y las colisiones.
        ControlPersonaje.Move(direccionDeMovimiento);  
    }
}