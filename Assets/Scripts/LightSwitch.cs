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

    private bool luzEncendida = false;

    private void Start()
    {
        pwr = FindObjectOfType<Power>();
        pnts = FindObjectOfType<Points>();
        gs = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnMouseEnter()
    {
        if (luzEncendida && pwr.pwr < 1)
        {
            gs.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
        }

        if (luzEncendida && pwr.pwr >= 1)
        {
            gs.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
        }
    }

    private void OnMouseExit()
    {
        if (luzEncendida)
        {
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }

    private void OnMouseDown()
    {
        if (pwr.pwr >= 1)
        {
            luzEncendida = !luzEncendida;
            luzDeLaHabitacion.enabled = luzEncendida;
            pwr.pwr -= 1;
            pnts.puntos += 10;
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }
}
