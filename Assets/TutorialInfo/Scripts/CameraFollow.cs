using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // 機器人的 Transform
    public Vector3 offset = new Vector3(0, 5, -10); // 攝影機偏移

    void LateUpdate()
    {
        if (target != null)
        {
            transform.position = target.position + offset;
            transform.LookAt(target.position); // 讓攝影機面向機器人
        }
    }
}

