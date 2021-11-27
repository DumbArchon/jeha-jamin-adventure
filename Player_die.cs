using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_die : MonoBehaviour
{
    private Playercontroller playerController;

    private void Awake()
    {
        playerController = GetComponent<Playercontroller>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            playerController.OnDie();
        }
    }
}
