using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightForce : MonoBehaviour
{
    public Rigidbody rb;
    
    void Start()
    {
       rb = GetComponent<Rigidbody>();
       rb.AddForce(Vector3.right * 500);
    }
}
