using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class TestMovementComponent : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f; // Szybkość poruszania postaci
    [SerializeField] private InputActionAsset actions;
    private InputAction moveAction;
    private Rigidbody rb; // Referencja do Rigidbody2D postaci
    private Vector2 moveInput; // Wektor wejściowy ruchu

    private void Start()
    {
        rb = GetComponent<Rigidbody>(); // Pobieranie Rigidbody2D postaci na początku
        moveAction = actions.FindAction("Move");
        moveAction.Enable();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(moveInput.x, 0, moveInput.y) * moveSpeed; // Ustawianie prędkości ruchu postaci
    }

    private void Update()
    {
        moveInput = moveAction.ReadValue<Vector2>();
    }
}