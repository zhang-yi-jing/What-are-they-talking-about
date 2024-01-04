using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Ҫ�����Ŀ������
    public float smoothSpeed = 0.125f; // ����������ƽ���ٶ�
    public Vector3 offset; // �������Ŀ������֮���ƫ����

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // �����������Ŀ��λ��
        desiredPosition.z = target.position.z - 10f; // ���������z��λ������ΪĿ�������z��λ�ü�10f
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // ƽ���ƶ������
        transform.position = smoothedPosition; // ���������λ��
    }
}