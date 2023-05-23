using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chave : MonoBehaviour
{
    public bool temChave = false;
    public Image ch;
    public AudioSource coletavel;
    private void OnCollisionEnter(Collision collision)
    {        
        if (collision.collider.CompareTag("Chave"))
        {
            coletavel.Play();
            temChave = true;
            Destroy(collision.gameObject);
            ch.gameObject.SetActive(true);
        }
    }
}
