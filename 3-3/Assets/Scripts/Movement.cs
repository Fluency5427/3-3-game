using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Controller movementController;
    private Rigidbody2D movementRigidbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        // ���� ���ӿ�����Ʈ�� TopDownController, Rigidbody�� ������ �� 
        movementController = GetComponent<Controller>();
        movementRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // OnMoveEvent�� Move�� ȣ���϶�� �����
        movementController.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        // ���� ������Ʈ���� ������ ����
        ApplyMovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        // �̵����⸸ ���صΰ� ������ ���������� ����.
        // �����̴� ���� ���� ������Ʈ���� ����(rigidbody�� �����ϱ�)
        movementDirection = direction;
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;

        movementRigidbody.velocity = direction;
    }
}