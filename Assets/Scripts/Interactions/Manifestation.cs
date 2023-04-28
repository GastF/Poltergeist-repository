using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manifestation : MonoBehaviour
{
    public Power pwr;
    public Points pnts;
    public GameObject gs;
    public GameObject M;

    private bool manifested = false;
    private Animator animator;
    

    private void Start()
    {
        animator = GetComponent<Animator>();
        pwr = FindObjectOfType<Power>();
        pnts = FindObjectOfType<Points>();
        gs = GameObject.FindGameObjectWithTag("Player");
        M.GetComponent<Animator>().enabled = false;
    }

    private void OnMouseEnter()
    {
        if (!manifested && pwr.pwr < 6)
        {
            gs.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
        }

        if (!manifested && pwr.pwr >= 6)
        {
            gs.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
        }
    }

    private void OnMouseExit()
    {
        if (!manifested)
        {
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }

    private void OnMouseDown()
    {
        if (!manifested && pwr.pwr >= 6)
        {
           
            manifested = true;
            pwr.pwr -= 6;
            pnts.puntos += 60;
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
            M.GetComponent<Animator>().enabled = true;
        }
    }
}