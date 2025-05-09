using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public int mode = 0; // 0: �̵�, 1: ȸ��
    public float moveSpeed = 2f;
    public float moveDistance = 3f;
    public float rotateSpeed = 90f; // �ʴ� ȸ�� ���� (�� ����)

    private Vector3 startPos;
    private int direction = 1;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (mode == 0)
        {
            MoveObject();
            CheckDirection();
        }
        else if (mode == 1)
        {
            RotateObject();
        }
    }

    private void MoveObject()
    {
        transform.Translate(Vector3.right * direction * moveSpeed * Time.deltaTime);
    }

    private void CheckDirection()
    {
        if (Mathf.Abs(transform.position.x - startPos.x) >= moveDistance)
        {
            direction *= -1;
        }
    }

    private void RotateObject()
    {
        transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime);
    }
}
