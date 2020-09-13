using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Player player;
    public GameObject gameWinScreen;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            gameWinScreen.SetActive(true);
            player.Disable();
        }
    }
}
