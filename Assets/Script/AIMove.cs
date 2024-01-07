using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    public Transform[] objs;
    Transform target;
    int index = 0;

    public float movementSpeed = 5f; // �ƶ��ٶ�

    void Start()
    {
        target = objs[index];
    }

    void Update()
    {
        // ������ҵ��˶�����
        Vector2 moveDirection = (target.position - transform.position).normalized;

        // ����λ��
        Vector3 newPosition = transform.position + (Vector3)moveDirection * movementSpeed * Time.deltaTime;
        transform.position = newPosition;

        if (Vector2.Distance(transform.position, target.position) <= 0.1f)
        {
            target = objs[++index];
            if (index >= 3)
            {
                index = -1;
            }
        }
    }
}