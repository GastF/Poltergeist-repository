using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public Image img;
    public Points points;
    public int i;
    public int ID;

    private void Start()
    {
        points = FindObjectOfType<Points>();
    }

    // Color del fantasma
    private void OnMouseEnter()
    {
        img.color = new Color32(255, 0, 0, 100);
    }

    private void OnMouseExit()
    {
        img.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
    }

    //Sumar puntos
    private void OnMouseDown()
    {
        points.PointUp(i);
        points.curr = ID;
        //Desactiva funcion de los puntos
        GetComponent<BoxCollider2D>().enabled = false;
    }
}
