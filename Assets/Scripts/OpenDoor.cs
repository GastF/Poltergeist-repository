using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Power pwr;
    public Points pnts;

    private bool doorOpen = false;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        pwr = FindObjectOfType<Power>();
        pnts = FindObjectOfType<Points>();
    }

    private void OnMouseDown()
    {
        if (!doorOpen && pwr.pwr >= 3)
        {
                animator.enabled = true;
                doorOpen = true;
                pwr.pwr -= 3;
                pnts.puntos += 750;
        }
    }
}
