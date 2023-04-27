using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostShadow : MonoBehaviour
{
    private bool clickOnWindow = false;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (!clickOnWindow)
        {
            animator.enabled = true;
            clickOnWindow = true;
        }
    }
}
