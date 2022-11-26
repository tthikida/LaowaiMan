using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 4f;
    [SerializeField] private float stoppingDistance = 0.1f;
    private Vector3 targetPosition;


    void Update()
    {
        if(Vector3.Distance(targetPosition, transform.position) > stoppingDistance)
        {
            Move();
        }

        if (Input.GetKey("t"))
        {
            SetTargetPosition(new Vector3(4,0,  4));
        }

    }

    private void Move()
    {
        Vector3 moveDirection = (targetPosition - transform.position).normalized;
        transform.position += moveDirection * Time.deltaTime * moveSpeed;
    }

    private void SetTargetPosition(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }

    


}
