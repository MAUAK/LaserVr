using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Referência ao prefab do inimigo
    public Transform[] spawnPoints; // Array contendo os pontos de spawn

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        // Escolhe um ponto de spawn aleatório do array de spawnPoints
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        // Instancia o inimigo no ponto de spawn selecionado
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
