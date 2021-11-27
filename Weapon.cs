using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private GameObject projectilePrefab;
    [SerializeField]
    private float   attackRate = 0.25f;
    private int     attackLevel = 1;
    [SerializeField]
    private GameObject boomPrefab;
    private int boomCount = 3;
    private boomcounter Boomcounter;

    


    public int BoomCount => boomCount;

    public void StartFiring()
    {
        StartCoroutine("TryAttack");
    }
    public void StopFiring()
    {
        StopCoroutine("TryAttack");
    }
    public void StartBoom()
    {

        if (boomCount > 0)
        {
            boomCount--;
            Instantiate(boomPrefab, transform.position, Quaternion.identity);
            Boomcounter.UpdateBoomicon(boomCount);
        }
    }
    private IEnumerator TryAttack()
    {
        while (true)
        {
            AttackBylevel();

            yield return new WaitForSeconds(attackRate);
        }
    }

    private void AttackBylevel()
    {
        GameObject cloneProjectile = null;

        switch( attackLevel )
        {
            case 1:
                Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                break;
            case 2:
                Instantiate(projectilePrefab, transform.position + Vector3.left * 0.2f, Quaternion.identity);
                Instantiate(projectilePrefab, transform.position + Vector3.right * 0.2f, Quaternion.identity);
                break;
            case 3:
                Instantiate(projectilePrefab, transform.position, Quaternion.identity);

                cloneProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                cloneProjectile.GetComponent<Movement2D>().MoveTo(new Vector3(-0.2f, 1, 0));

                cloneProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                cloneProjectile.GetComponent<Movement2D>().MoveTo(new Vector3(0.2f, 1, 0));
                break;

        }

    }
}
