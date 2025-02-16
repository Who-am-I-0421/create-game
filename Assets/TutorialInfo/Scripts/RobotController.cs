using UnityEngine;

public class RobotController : MonoBehaviour
{
    public float moveSpeed = 1f; // 控制移动速度
    private Rigidbody rb;
    private Vector3 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * 0.3f; // A (-1) 和 D (1)
        float moveZ = Input.GetAxis("Vertical") * 0.3f;   // W (1) 和 S (-1)

        moveDirection = new Vector3(moveX, 0f, moveZ).normalized; // 方向向量归一化

        // 只有在移动时才旋转角色
        if (moveDirection.magnitude > 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(moveDirection);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10f); // 平滑旋转
        }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveDirection * moveSpeed + new Vector3(0, rb.linearVelocity.y, 0);
    }
}
