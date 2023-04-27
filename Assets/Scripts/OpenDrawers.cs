using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawers : MonoBehaviour
{
    public Power pwr;
    public Points pnts;
    
    private bool cajonAbierto = false;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        pwr = FindObjectOfType<Power>();
        pnts = FindObjectOfType<Points>();
    }

    private void OnMouseDown()
    {
        if (!cajonAbierto && pwr.pwr >= 4)
        {
                animator.enabled = true;
                cajonAbierto = true;
                pwr.pwr -= 4;
                pnts.puntos += 1000;
        }
    }
}
