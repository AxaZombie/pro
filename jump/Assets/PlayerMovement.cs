using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Rigidbody2D 컴포넌트를 가져옴
    }

    void Update()
    {
        // 입력 감지 (WASD 및 화살표 키)
        movement.x = Input.GetAxisRaw("Horizontal"); // -1 (좌), 0, 1 (우)
        movement.y = Input.GetAxisRaw("Vertical");   // -1 (하), 0, 1 (상)
    }

    void FixedUpdate()
    {
        // Rigidbody2D를 이용한 이동
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
