using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlamShelf : MonoBehaviour
{
    public float pushForce = 50f;

    public bool canBeClicked = true;

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
        if (canBeClicked && pwr.pwr >= 4)
        {
                canBeClicked = false; // desactiva el clickeo para que la acción no se repita
                rb.AddForce(transform.forward * pushForce, ForceMode.Impulse);
                pwr.pwr -= 4;
                pnts.puntos += 1000;
        }
    }
}

