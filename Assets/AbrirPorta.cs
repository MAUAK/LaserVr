using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AbrirPorta : MonoBehaviour
{
    public chave ch;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && ch.temChave == true)
        {
            SceneManager.LoadScene("Vitoria");
        }
    }
}
