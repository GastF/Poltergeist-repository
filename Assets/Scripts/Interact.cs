using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public Image img; //Fantasma
    public Points points; //El sistema de puntos
    public Sprite spr; //Imagen de que fue usado
    public int i; //Cuantos puntos da
    public int ID; //Orden de secuencia

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
        img.color = new Color32(255, 255, 255, 100);
    }

    //Sumar puntos
    private void OnMouseDown()
    {
        points.PointUp(i);
        points.curr = ID;
        //Desactiva interacción con el objeto
        GetComponent<BoxCollider2D>().enabled = false;

        //Cambia la imagen del objeto
        GetComponent<SpriteRenderer>().sprite = spr;
    }
}
