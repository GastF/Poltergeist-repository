using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSoccerBall : MonoBehaviour
{
    public float pushForce = 10f; 
 
    public bool canBeClicked = true;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnMouseDown()
    {
        if (canBeClicked)
        {
            canBeClicked = false; // desactiva el clickeo para que la acción no se repita
            rb.AddForce(transform.forward * -pushForce, ForceMode.Impulse);
            rb.AddForce(transform.right * -pushForce, ForceMode.Impulse);
        }
    }
}
