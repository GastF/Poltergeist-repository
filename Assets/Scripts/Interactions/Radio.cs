using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Radio : MonoBehaviour
{
    public Power pwr;
    public Points pnts;
    public GameObject gs;

    private bool radio = false;
   

    private void Start()
    {
        
        pwr = FindObjectOfType<Power>();
        pnts = FindObjectOfType<Points>();
        gs = GameObject.FindGameObjectWithTag("Player");
       
    }

    private void OnMouseEnter()
    {
        if (!radio && pwr.pwr < 3)
        {
            gs.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
        }

        if (!radio && pwr.pwr >= 3)
        {
            gs.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
        }
    }
    private void OnMouseExit()
    {
        if (!radio)
        {
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }

    private void OnMouseDown()
    {
        if (!radio && pwr.pwr >= 3)
        {
            AkSoundEngine.PostEvent("Play_radio", gameObject);
            radio = true;
            pwr.pwr -= 3;
            pnts.puntos += 35;
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }
}
