using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 으응애 : MonoBehaviour
{
    [SerializeField]
    private Transform   target;
    [SerializeField]
    private float scrollrange = 9.9f;
    [SerializeField]
    private float movespeed = 3.0f;
    [SerializeField]
    private Vector3  moveDirection = Vector3.down;

    private void Update()
    {
        transform.position += moveDirection * movespeed * Time.deltaTime;

        if (transform.position.y <= -scrollrange )
        {
            transform.position = target.position + Vector3.up * scrollrange;
        }
    }
}
