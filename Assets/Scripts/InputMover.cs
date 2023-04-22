using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class InputMover : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] InputAction moveHorizontal;
    private Rigidbody rb;

    void OnEnable()
    {
        moveHorizontal.Enable();
    }

    void OnDisable()
    {
        moveHorizontal.Disable();
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void OnValidate()
    {

        if (moveHorizontal == null)
        {
            moveHorizontal = new InputAction(type: InputActionType.Button);
        }
        if (moveHorizontal.bindings.Count == 0)
        {
            moveHorizontal.AddCompositeBinding("1DAxis").With("Positive", "<Keyboard>/rightArrow")
                .With("Negative", "<Keyboard>/leftArrow");
        }
    }
    void FixedUpdate()
    {
        float horizontal = moveHorizontal.ReadValue<float>();
        Vector3 movementVector = new Vector3(horizontal, 0, 0) * speed * Time.deltaTime;
        transform.position += movementVector;
    }
}
