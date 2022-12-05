using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

        if (materialName == "Unsafe Color (Instance)" || materialName ==  "Unsafe Color 1 (Instance)" || materialName == "Unsafe Color 2 (Instance)")
        {
            PlayerPrefs.SetInt("score", 0);
            Time.timeScale = 0f;
            gameoverscreen.gameObject.SetActive(true);
        }
        else if (materialName == "Last Ring (Instance)")
        {   
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}