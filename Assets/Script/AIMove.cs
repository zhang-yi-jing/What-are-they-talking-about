using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    public Transform[] objs;
    Transform target;
    int index = 0;

    public float movementSpeed = 5f; // 移动速度

    void Start()
    {
        target = objs[index];
    }

    void Update()
    {
        // 计算玩家的运动方向
        Vector2 moveDirection = (target.position - transform.position).normalized;

        // 更新位置
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