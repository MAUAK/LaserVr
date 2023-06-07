using UnityEngine;

public class EnemySound : MonoBehaviour
{
    public AudioClip chaseSound; // Áudio de perseguição
    public AudioSource audioSource; // Componente de áudio

    private void Start()
    {
        audioSource = GetComponent<AudioSource>(); // Obtém o componente de áudio no inimigo
    }

    public void PlayChaseSound()
    {
        audioSource.clip = chaseSound; // Define o áudio de perseguição no componente de áudio
        audioSource.Play(); // Reproduz o som
    }
}
