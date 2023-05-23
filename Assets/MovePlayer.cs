using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 5;
    bool isFoward = false;
    bool isBack = false;
    bool isLeft = false;
    bool isRight = false;
    public AudioSource passos;

    void Update()
    {

        if (isFoward)
        {
            transform.Translate(0, 0, (speed * Time.fixedDeltaTime));            
        }
        else if (isBack)
        {
            transform.Translate(0, 0, (-speed * Time.fixedDeltaTime));
        }
        else if (isLeft)
        {
            transform.Rotate(0, ((-speed-60) * Time.fixedDeltaTime), 0);
        }
        else if (isRight)
        {
            transform.Rotate(0, ((speed + 60) * Time.fixedDeltaTime), 0);
        }
        else
        {
            DisableMoveController();
            passos.Pause    ();
        }
    }

    void EnableMoveController(bool frente, bool tras, bool esqueda, bool direita)
    {
        if (frente)
            isFoward = frente;
        if (tras)
            isBack = tras;
        if (esqueda)
            isLeft = esqueda;
        if (direita)
            isRight = direita;

    }

    public void DisableMoveController()
    {
        
        isFoward = false;
        isBack = false;
        isLeft = false;
        isRight = false;
        
    }

    public void Foward()
    {
        EnableMoveController(true, false, false,false);
        passos.Play();
    }

    public void Back()
    {
        EnableMoveController(false,true,false,false);
        passos.Play();
    }

    public void Left()
    {
        EnableMoveController(false,false,true,false);
        passos.Play();
    }

    public void Right()
    {
        EnableMoveController(false,false,false,true);
        passos.Play();
    }
}
