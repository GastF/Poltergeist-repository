using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlamBook : MonoBehaviour
{
    public float pushForce = 10f; // fuerza con la que se empujará el libro hacia adelante
    public float pushBackForce = 2f; // fuerza con la que se empujará el libro hacia atrás antes de salir disparado
    public bool canBeClicked = true; // indica si el libro puede ser clickeado o no

    public Power pwr;
    public Points pnts;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pwr = FindObjectOfType<Power>();
        pnts = FindObjectOfType<Points>();
    }

    void OnMouseDown()
    {
        if (canBeClicked && pwr.pwr >= 2)
        {
                canBeClicked = false; // desactiva el clickeo para que la acción no se repita
                rb.AddForce(transform.forward * pushBackForce, ForceMode.Impulse); // empuja el libro hacia atrás
                rb.AddForce(transform.forward * -pushForce, ForceMode.Impulse); // empuja el libro hacia adelante
                pwr.pwr -= 2;
                pnts.puntos += 500;
        }
    }
}


