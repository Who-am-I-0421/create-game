using UnityEngine;

public class RotateGear : MonoBehaviour
{
    public float rotationSpeed = 100f; // 控制旋转速度

    void Update()
    {
        // 绕 Z 轴持续旋转
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
