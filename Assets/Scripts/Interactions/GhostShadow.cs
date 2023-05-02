using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostShadow : MonoBehaviour
{
    public Power pwr;
    public Points pnts;
    public GameObject gs;
    

    private bool clickOnWindow = false;
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
        if (!clickOnWindow && pwr.pwr < 5)
        {
            gs.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
        }

        if (!clickOnWindow && pwr.pwr >= 5)
        {
            gs.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
        }
    }

    private void OnMouseExit()
    {
        if (!clickOnWindow)
        {
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }

    private void OnMouseDown()
    {
        if (!clickOnWindow && pwr.pwr >= 5)
        {
            AkSoundEngine.PostEvent("Play_window_f", gameObject);
            animator.enabled = true;
            clickOnWindow = true;
            pwr.pwr -= 5;
            pnts.puntos += 50;
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }
}
