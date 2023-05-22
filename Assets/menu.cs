using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
   public void iniciarGame()
    {
        SceneManager.LoadScene("demoScene_free");
    }

   public void QuitGame()
    {
        Debug.Log("Saindo do jogo!");
        Application.Quit();
    }
}
