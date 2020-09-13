using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Player player;
    public GameObject gameOverScreen;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(transform.gameObject);
            player.Disable();
            gameOverScreen.SetActive(true);
        }
    }
}
