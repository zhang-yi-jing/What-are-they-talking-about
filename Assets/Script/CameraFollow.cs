using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // 要跟随的目标物体
    public float smoothSpeed = 0.125f; // 摄像机跟随的平滑速度
    public Vector3 offset; // 摄像机和目标物体之间的偏移量

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // 计算摄像机的目标位置
        desiredPosition.z = target.position.z - 10f; // 将摄像机的z轴位置设置为目标物体的z轴位置加10f
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // 平滑移动摄像机
        transform.position = smoothedPosition; // 更新摄像机位置
    }
}