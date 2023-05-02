using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    Vector3 temp;
    private float x = 40;
    private float y = -40;

    
    void Update()
    {
        //Fantasma sigue el mouse
        temp = Input.mousePosition;
        /*temp.x = Input.mousePosition.x + x;
        temp.y = Input.mousePosition.y + y;
        temp.z += 1;*/
        this.transform.position = temp;
    }
}
