using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Orb : MonoBehaviour
{
    public GameObject slamShelf; // Referencia al objeto estanter�a
    public GameObject gs;
    public bool canBeClicked = true;

    private void Start()
    {
        gs = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnMouseEnter()
    {

        if (canBeClicked)
        {
            gs.GetComponent<Image>().color = new Color32(0, 255, 0, 100);
        }
        else
        {
            gs.GetComponent<Image>().color = new Color32(255, 0, 0, 100);
        }
    }
    private void OnMouseExit()
    {
        if (canBeClicked)
        {
            gs.GetComponent<Image>().color = new Color32(255, 255, 255, 100);
        }
    }
    private void OnMouseDown()
    {
        // Al hacer click en el orbe, se destruye el objeto
        Destroy(gameObject);

        // Se verifica si ya se han destruido los tres orbes
        if (GameObject.FindGameObjectsWithTag("Orb").Length == 0)
        {
            // Si se han destruido los tres orbes, se habilita el clickeo en la estanter�a
            slamShelf.GetComponent<SlamShelf>().canBeClicked = true;
        }
    }

}