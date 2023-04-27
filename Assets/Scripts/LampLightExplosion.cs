using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampLightExplosion : MonoBehaviour
{
    public Power pwr;
    public Points pnts;

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
    }

    private void OnMouseDown()
    {
        if (!isExploding && pwr.pwr >= 4)
        {
            currentIntensity += 1f;
            lampLight.intensity = currentIntensity;
            pwr.pwr -= 4;

            if (currentIntensity >= maxIntensity)
            {
                isExploding = true;
                lampLight.intensity = explosionIntensity;
                pnts.puntos += 1000;
                Destroy(lampLight, 0.3f);
            }
        }
    }
}
