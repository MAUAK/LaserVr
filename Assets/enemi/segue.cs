using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class segue : MonoBehaviour
{
    public string playerPrefabPath; // Caminho do prefab do jogador na pasta Resources
    public float speed = 3f;

    private GameObject playerObject;
    private Transform playerTransform;

    private void Start()
    {
        // Carrega o prefab do jogador da pasta Resources
        playerObject = Resources.Load<GameObject>(playerPrefabPath);

        if (playerObject != null)
        {
            // Instancia o jogador no cenário
            playerTransform = Instantiate(playerObject).transform;
        }
    }

    private void Update()
    {
        if (playerTransform != null)
        {
            // Calcula a direção para onde o jogador está
            Vector3 direction = playerTransform.position - transform.position;
            direction.Normalize();

            // Move o inimigo na direção do jogador
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
