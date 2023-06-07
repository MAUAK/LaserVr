using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombieScript : MonoBehaviour
{
    public GameObject zombiePrefab; // Prefab do inimigo
    public float spawnDistance = 10f; // Distância de spawn em relação ao jogador

    private Transform player;
    private NavMeshAgent agent;
    private Animator animator;
    public EnemySound enemySound; // Referência ao script EnemySound

    private bool isDead = false;

    void Start()
    {
        player = Camera.main.transform;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        agent.destination = player.position;
        animator.SetBool("isWalking", true);
        enemySound = GetComponent<EnemySound>(); // Obtém o script EnemySound no inimigo

    }

    void Update()
    {

        if (!isDead)
        {
            
            agent.destination = player.position;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (!isDead && other.CompareTag("bullet"))
        {
            isDead = true;

            Destroy(other.gameObject); // Destruir a bala

            // Parar o inimigo e iniciar a animação de morte
            agent.isStopped = true;
            animator.SetTrigger("dead");

            // Chamar a função SpawnZombie após a animação de morte
            StartCoroutine(SpawnZombie());
        }
    }

    IEnumerator SpawnZombie()
    {
        // Aguardar o término da animação de morte
        float deathAnimationDuration = animator.GetCurrentAnimatorStateInfo(0).length;
        yield return new WaitForSeconds(deathAnimationDuration);

        // Calcular uma posição longe do jogador para spawnar o novo inimigo
        Vector3 spawnPosition = player.position + (Random.insideUnitSphere * spawnDistance);
        spawnPosition.y = 0f;

        // Spawn de um novo inimigo
        GameObject newZombie = Instantiate(zombiePrefab, spawnPosition, Quaternion.identity);
        newZombie.GetComponent<zombieScript>().SetPlayer(player);
   
        Destroy(gameObject); // Destruir o inimigo atual
    }


    public void SetPlayer(Transform newPlayer)
    {
        player = newPlayer;
        enemySound.PlayChaseSound(); // Reproduz o som de perseguição
    }
}