using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 범위밖삭제 : MonoBehaviour
{
    [SerializeField]
    private 배경 stageData;
    private float destroyWeight = 1.25f;

    private void LateUpdate()
    {
        if (transform.position.y < stageData.LimitMin.y - destroyWeight ||
           transform.position.y > stageData.LimitMax.y + destroyWeight ||
           transform.position.x < stageData.LimitMin.x - destroyWeight ||
           transform.position.x > stageData.LimitMax.x + destroyWeight)
        {
            Destroy(gameObject);
        }
    }
}
