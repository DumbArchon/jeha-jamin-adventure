using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 적체력 : MonoBehaviour
{
    [SerializeField]
    private float maxHP = 4;
    private float currentHp;
    private 적 적;
    private SpriteRenderer spriteRenderer;
    private void Awake()
    {
        currentHp = maxHP;
        적 = GetComponent<적>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }

    public void TakeDamage(float damage)
    {
        currentHp -= damage;

        StopCoroutine("HitColorAnimation");
        StartCoroutine("HitColorAnimation");

        if (currentHp <= 0)
        {
            적.OnDie();
        }
    }

    private IEnumerator HitColorAnimation()
    {
        spriteRenderer.color = Color.red;

        yield return new WaitForSeconds(0.05f);

        spriteRenderer.color = Color.white;
    }

}
