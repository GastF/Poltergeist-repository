using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampLightExplosion : MonoBehaviour
{

    private Light lampLight;
    private bool isExploding = false;
    private float currentIntensity = 4f;
    private float maxIntensity = 10f;
    private float explosionIntensity = 25f;

    private void Start()
    {
        lampLight = GetComponent<Light>();
    }

    private void OnMouseDown()
    {
        if (!isExploding)
        {
            currentIntensity += 1f;
            lampLight.intensity = currentIntensity;

            if (currentIntensity >= maxIntensity)
            {
                isExploding = true;
                lampLight.intensity = explosionIntensity;
                Destroy(lampLight, 0.3f);
            }
        }
    }
}
