using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mensagem : MonoBehaviour
{
    public Text texto;
    [Range(0.1f, 10.0f)] public float distancia = 3;
    private GameObject jogador;
    void Start()
    {
        texto.enabled = false;
        jogador = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        if (Vector3.Distance(transform.position, jogador.transform.position) < distancia)
        {
            texto.enabled = true;
        }
        else
        {
            texto.enabled = false;
        }

    }
}
