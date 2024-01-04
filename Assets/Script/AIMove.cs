using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMove : MonoBehaviour
{
    public Transform[] objs;
    Transform target;
    int index = 0;

    public float movementSpeed = 5f; // �ƶ��ٶ�
    public float rotationSpeed = 5f; // ��ת�ٶ�

    void Start()
    {
        target = objs[index];
    }

    void Update()
    {
        // ������ҵ��˶�����
        Vector2 moveDirection = (target.position - transform.position).normalized;

        // ������ҵ�Ŀ��Ƕ�
        float targetAngle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;

        // ƽ����ֵ��ת
        float currentAngle = Mathf.LerpAngle(transform.rotation.eulerAngles.z, targetAngle, rotationSpeed * Time.deltaTime);
        transform.rotation = Quaternion.AngleAxis(currentAngle, Vector3.forward);

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