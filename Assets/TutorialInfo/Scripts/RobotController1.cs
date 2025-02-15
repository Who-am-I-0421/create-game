using UnityEngine;

public class RobotController1 : MonoBehaviour
{
    public float moveSpeed = 5f;  // 移动速度
    private Rigidbody rb;
    private Vector3 moveDirection;
    private Animator animator;  // 引用 Animator 组件

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();  // 获取 Animator 组件
    }

    void Update()
    {
        // 获取玩家的输入
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        // 计算移动方向
        moveDirection = new Vector3(moveX, 0f, moveZ).normalized;

        // 如果有输入（玩家移动），设置 IsWalking 为 true，播放 Walk 动画
        if (moveDirection.magnitude > 0)
        {
            animator.SetBool("IsWalking", true);  // 移动时播放 Walk 动画
        }
        else
        {
            animator.SetBool("IsWalking", false);  // 停止时播放 Idle 动画
        }
    }

    void FixedUpdate()
    {
        // 使用 Rigidbody 进行物理移动
        rb.linearVelocity = moveDirection * moveSpeed + new Vector3(0, rb.linearVelocity.y, 0);
    }
}

