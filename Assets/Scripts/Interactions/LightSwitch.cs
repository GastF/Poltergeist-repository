using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSwitch : MonoBehaviour
{
    public Light luzDeLaHabitacion;

    public Power pwr;
    public Points pnts;
    public GameObject gs;
    private int lightBreak;

    private bool luzEncendida = false;

    private void Start()
    {
        pwr = FindObjectOfType<Power>();
        pnts = FindObjectOfType<Points>();
        gs = GameObject.FindGameObjectWithTag("Player");
        lightBreak = 0;
    }

    private void OnMouseEnter()
    {
        if (lightBreak < 3)
        {
            if (pwr.pwr < 1)
            {
                gs.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
            }

            if (pwr.pwr >= 1)
            {
                gs.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
            }
        }
        else { gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100); }
    }

    private void OnMouseExit()
    {
        
        
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        
    }

    private void OnMouseDown()
    {
        if (lightBreak < 3)
        {
            if (pwr.pwr >= 1)
            {
                AkSoundEngine.PostEvent("Play_light_click", gameObject);
                lightBreak++;
                luzEncendida = !luzEncendida;
                luzDeLaHabitacion.enabled = luzEncendida;
                pwr.pwr -= 1;
                pnts.puntos += 10;
                gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
            }
        }
        else { luzDeLaHabitacion.enabled = false;}
    }
}
