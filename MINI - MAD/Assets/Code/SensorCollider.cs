using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SensorCollider : MonoBehaviour
{
    PlayerController playerController;

    private void Awake()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("OHSHIT");
            playerController.Death();
        }
    }
}
