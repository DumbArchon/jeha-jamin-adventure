using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 충돌_발사체 : MonoBehaviour
{
    [SerializeField]
    private int damage = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<적체력>().TakeDamage(damage);

            Destroy(gameObject);
        }
    }
}
