using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpForce;

    public GameObject splashPrefab;

    public Image gameoverscreen;

    private void OnCollisionEnter(Collision collision)
    {
        rb.velocity = Vector3.up * jumpForce;
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0, -0.22f, 0), transform.rotation);
        splash.transform.SetParent(collision.gameObject.transform);

        string materialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;
        //Debug.Log(materialName);

        if(materialName == "Safe Color (Instance)")
        {

        }
        else if (materialName == "Unsafe Color (Instance)")
        {
            Time.timeScale = 0f;
            gameoverscreen.gameObject.SetActive(true);
        }
        else if (materialName == "Last Ring (Instance)")
        {
            //load new level
        }
    }
}