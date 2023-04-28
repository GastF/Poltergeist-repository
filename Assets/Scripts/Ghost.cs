using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    Vector3 temp;
    void Update()
    {
        //Fantasma sigue el mouse
        temp = Input.mousePosition;
        temp.z += 1;
        this.transform.position = temp;
    }
}
