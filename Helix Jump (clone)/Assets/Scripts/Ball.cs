using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = Vector3.up * jumpForce;

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        Debug.Log(materialName);

        if(materialName == "Safe Color (Instance)")
        {

        }
        else if (materialName == "Unsafe Color (Instance)")
        {

        }
        else if (materialName == "Last Ring (Instance)")
        {
            
        }
    }
}