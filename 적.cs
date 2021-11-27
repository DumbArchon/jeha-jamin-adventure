using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 적 : MonoBehaviour
{
    [SerializeField]
    private int scorePoint = 10;
    private Playercontroller playerController;
    [SerializeField]
    private GameObject DieEffect;
    new private Animation  animation;
    private void Awake()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<Playercontroller>();
    }

    public void OnDie()
    {
        playerController.Score += scorePoint;

        Destroy(gameObject);
    }
 
}
