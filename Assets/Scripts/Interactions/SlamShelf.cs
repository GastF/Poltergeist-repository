using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SlamShelf : MonoBehaviour
{
    public float pushForce = 50f;

    public bool canBeClicked = true;

    public Power pwr;
    public Points pnts;
    public GameObject gs;
 
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pwr = FindObjectOfType<Power>();
        pnts = FindObjectOfType<Points>();
        gs = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnMouseEnter()
    {

        if (canBeClicked && GameObject.FindGameObjectsWithTag("Orb").Length == 0)
        {
            gs.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
        }
        else
        {
            gs.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
        }
    }

    private void OnMouseExit()
    {
        if (canBeClicked)
        {
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }

    void OnMouseDown()
    {
        if (canBeClicked && GameObject.FindGameObjectsWithTag("Orb").Length == 0)
        {
                canBeClicked = false; // desactiva el clickeo para que la acción no se repita
                rb.AddForce(transform.forward * pushForce, ForceMode.Impulse);

        
            pnts.puntos += 200;
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }
}

