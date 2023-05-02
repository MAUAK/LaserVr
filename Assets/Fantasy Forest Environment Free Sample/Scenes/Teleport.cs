using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public void TeleportPlayer(Transform pos)
    {
        transform.position = pos.position;
    }

    public void mata(GameObject enn)
    {
        Destroy(enn);
        
    }

    public void laseentra(GameObject laser)
    {
        laser.SetActive(true);
    }

    public void lasesai(GameObject laser)
    {
        laser.SetActive(false);
    }

}
