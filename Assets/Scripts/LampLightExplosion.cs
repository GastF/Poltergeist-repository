using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LampLightExplosion : MonoBehaviour
{
    public Power pwr;
    public Points pnts;
    public GameObject gs;

    private Light lampLight;
    private bool isExploding = false;
    private float currentIntensity = 4f;
    private float maxIntensity = 10f;
    private float explosionIntensity = 25f;

    private void Start()
    {
        lampLight = GetComponent<Light>();
        pwr = FindObjectOfType<Power>();
        pnts = FindObjectOfType<Points>();
        gs = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnMouseEnter()
    {
        if (!isExploding && pwr.pwr < 4)
        {
            gs.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
        }

        if (!isExploding && pwr.pwr >= 4)
        {
            gs.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
        }
    }

    private void OnMouseExit()
    {
        if (!isExploding)
        {
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }

    private void OnMouseDown()
    {
        if (!isExploding && pwr.pwr >= 4)
        {
            currentIntensity += 1f;
            lampLight.intensity = currentIntensity;
            pwr.pwr -= 4;
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);

            if (currentIntensity >= maxIntensity)
            {
                isExploding = true;
                lampLight.intensity = explosionIntensity;
                pnts.puntos += 40;
                Destroy(lampLight, 0.3f);
            }
        }
    }
}
