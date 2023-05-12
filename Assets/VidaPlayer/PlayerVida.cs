using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerVida : MonoBehaviour
{
    public float Health;
    public Slider HealthBar;


    void Start()
    {
        HealthBar.value = Health;
    }

    void Update()
    {
        if (Health == 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer.Equals(8))
        {
            Health -= 10;
            HealthBar.value = Health;
        }
    }
}
