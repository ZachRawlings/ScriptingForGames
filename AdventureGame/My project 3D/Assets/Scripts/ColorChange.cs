using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color newColor = Color.green;


    void OnCollisionEnter(Collision collision)
    {
        //Change the object's color upon collision with another object
        GetComponent<Renderer>().material.color = newColor;
    }
}
