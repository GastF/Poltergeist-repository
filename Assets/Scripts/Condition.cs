using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Condition : MonoBehaviour
{
    public Text txt;
    public Text Btxt;
    public Button but;
    public Image[] img;
    public Points pnts;
    public float timer;
    public int[] stars;
    bool countdown = true;

    private void Start()
    {
        pnts = FindFirstObjectByType<Points>();
        img[0].gameObject.SetActive(false);
        img[1].gameObject.SetActive(false);
        img[2].gameObject.SetActive(false);
        but.gameObject.SetActive(false);
    }

    void Update()
    {
        if (countdown)
        {
            timer -= Time.deltaTime;
        }
        txt.text = timer.ToString();

        if (timer <= 0)
        {
            countdown = false;
            but.gameObject.SetActive(true);
            Btxt.text = "Te quedaste sin tiempo :(";
        }

        if (pnts.puntos >= stars[0] && timer <= 0)
        {
            img[0].gameObject.SetActive(true);
        }
        if (pnts.puntos >= stars[1] && timer <= 0)
        {
            img[1].gameObject.SetActive(true);
        }
        if (pnts.puntos >= stars[2])
        {
            img[0].gameObject.SetActive(true);
            img[1].gameObject.SetActive(true);
            img[2].gameObject.SetActive(true);

            countdown = false;
            but.gameObject.SetActive(true);
            Btxt.text = "GANASTE :)";
        }
    }
}
