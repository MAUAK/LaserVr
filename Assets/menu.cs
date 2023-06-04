using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
   public void iniciarGame()
    {
        SceneManager.LoadScene("Demo");
    }

    public void Menu()
    {
        SceneManager.LoadScene("Demo 1");
    }

    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void QuitGame()
    {
        Debug.Log("Saindo do jogo!");
        Application.Quit();
    }
}
