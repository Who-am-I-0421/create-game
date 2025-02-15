using UnityEngine;

public class RobotController : MonoBehaviour
{
    public float moveSpeed = 5f; // 控制移动速度
    private Rigidbody rb;
    private Vector3 moveDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal"); // A (-1) 和 D (1)
        float moveZ = Input.GetAxis("Vertical");   // W (1) 和 S (-1)

        moveDirection = new Vector3(moveX, 0f, moveZ).normalized; // 方向向量归一化
    }

    void FixedUpdate()
    {
        rb.linearVelocity = moveDirection * moveSpeed + new Vector3(0, rb.linearVelocity.y, 0);
    }
}
