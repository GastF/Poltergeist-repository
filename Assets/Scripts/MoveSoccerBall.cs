using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSoccerBall : MonoBehaviour
{
    public float pushForce = 10f; 
 
    public bool canBeClicked = true;

    private Rigidbody rb;

    public Power pwr;
    public Points pnt;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pwr = FindObjectOfType<Power>();
        pnt = FindObjectOfType<Points>();
    }

    void OnMouseDown()
    {
        if (canBeClicked && pwr.pwr >= 2)
        {
                canBeClicked = false; // desactiva el clickeo para que la acción no se repita
                rb.AddForce(transform.forward * -pushForce, ForceMode.Impulse);
                rb.AddForce(transform.right * -pushForce, ForceMode.Impulse);
                pwr.pwr -= 2;
                pnt.puntos += 500;
        }
    }
}
