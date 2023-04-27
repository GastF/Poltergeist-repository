using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawers : MonoBehaviour
{
    private bool cajonAbierto = false;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        if (!cajonAbierto)
        {
            animator.enabled = true;
            cajonAbierto = true;
        }
    }
}
