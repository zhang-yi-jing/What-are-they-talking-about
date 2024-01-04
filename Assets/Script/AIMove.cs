using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    public Transform[] objs;
    Transform target;
    int index = 0;

    public float movementSpeed = 5f; // 移动速度
    public float rotationSpeed = 5f; // 旋转速度

    void Start()
    {
        target = objs[index];
    }

    void Update()
    {
        // 计算玩家的运动方向
        Vector2 moveDirection = (target.position - transform.position).normalized;

        // 计算玩家的目标角度
        float targetAngle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;

        // 平滑插值旋转
        float currentAngle = Mathf.LerpAngle(transform.rotation.eulerAngles.z, targetAngle, rotationSpeed * Time.deltaTime);
        transform.rotation = Quaternion.AngleAxis(currentAngle, Vector3.forward);

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