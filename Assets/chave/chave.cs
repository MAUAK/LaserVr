using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chave : MonoBehaviour
{
    public Image ch;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Chave"))
        {
            Destroy(collision.gameObject);
            ch.gameObject.SetActive(true);
        }
    }
}
