using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDrawers : MonoBehaviour
{
    public Power pwr;
    public Points pnts;
    public GameObject gs;
    
    private bool cajonAbierto = false;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        pwr = FindObjectOfType<Power>();
        pnts = FindObjectOfType<Points>();
        gs = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnMouseEnter()
    {
        if (!cajonAbierto && pwr.pwr < 4)
        {
            gs.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
        }

        if (!cajonAbierto && pwr.pwr >= 4)
        {
            gs.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
        }
    }

    private void OnMouseExit()
    {
        if (!cajonAbierto)
        {
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }

    private void OnMouseDown()
    {
        if (!cajonAbierto && pwr.pwr >= 4)
        {
                animator.enabled = true;
                cajonAbierto = true;
                pwr.pwr -= 4;
                pnts.puntos += 40;
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }
}
