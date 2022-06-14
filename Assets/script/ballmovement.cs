using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump")) { 
            // rigid.AddForce(Vector3.up * 25, ForceMode.Impulse);
        }

        float h = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Jump");
        float v = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(h, z, v);

        rigid.AddForce(vec, ForceMode.Impulse); 

    }
}
