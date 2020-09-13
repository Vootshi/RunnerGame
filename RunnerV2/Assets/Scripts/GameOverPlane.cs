using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPlane : MonoBehaviour
{
    public GameObject afterFallScreen;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        afterFallScreen.SetActive(true);
    }
}
