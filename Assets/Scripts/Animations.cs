using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Animations : MonoBehaviour
{
    public Points pointsScript;
    public int points;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        pointsScript = GameObject.Find("EventSystem").GetComponent<Points>();
        points = pointsScript.puntos;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         points = pointsScript.puntos;

        if (points >= 30 && points < 50)
        {
            anim.SetTrigger("Alert");
        }
        else if (points >= 50 && points < 100)
        {
            anim.SetTrigger("Stand");
            anim.SetTrigger("Idle");
        }
        else if (points >= 140 && points < 280)
        {
            anim.SetTrigger("Terrified");
        }
        else if (points >= 280 && points < 450)
        {
            anim.SetTrigger("RunTurn");
        }
        else if (points >= 450)
        {
            anim.SetTrigger("Running");
        }

    }
}
