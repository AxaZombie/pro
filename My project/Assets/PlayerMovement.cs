using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            Debug.Log("�׾����ϴ�!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // �����
        }
        else if (collision.gameObject.CompareTag("Goal"))
        {
            Debug.Log("Ŭ����!");
            // ���� ���ϴ� ���� (���� �� �ε� ��) �߰�
        }
    }
}
