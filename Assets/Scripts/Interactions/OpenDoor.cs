using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDoor : MonoBehaviour
{
    public Power pwr;
    public Points pnts;
    public GameObject gs;

    private bool doorOpen = false;
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
        if (!doorOpen && pwr.pwr < 2)
        {
            gs.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
        }

        if (!doorOpen && pwr.pwr >= 2)
        {
            gs.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
        }
    }
    private void OnMouseExit()
    {
        if (!doorOpen)
        {
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }

    private void OnMouseDown()
    {
        if (!doorOpen && pwr.pwr >= 2)
        {
                AkSoundEngine.PostEvent("Play_door", gameObject);
                animator.enabled = true;
                doorOpen = true;
                pwr.pwr -= 2;
                pnts.puntos += 20;
                gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }
}
