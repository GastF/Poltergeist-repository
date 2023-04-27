using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostShadow : MonoBehaviour
{
    public Power pwr;
    public Points pnts;

    private bool clickOnWindow = false;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        pwr = FindObjectOfType<Power>();
        pnts = FindObjectOfType<Points>();
    }

    private void OnMouseDown()
    {
        if (!clickOnWindow && pwr.pwr >= 5)
        {
            animator.enabled = true;
            clickOnWindow = true;
            pwr.pwr -= 5;
            pnts.puntos += 1500;
        }
    }
}
