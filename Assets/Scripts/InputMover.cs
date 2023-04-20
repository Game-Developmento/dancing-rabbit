using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class InputMover : MonoBehaviour
{
    // [Tooltip("The vertical force that the player's feet use for jumping, in newtons.")]
    // [SerializeField] float jumpImpulse = 5f;

    // [Range(0, 1f)]
    // [SerializeField] float slowDownAtJump = 0.5f;
    // [SerializeField] InputAction jump;

    [SerializeField] float speed = 10f;


    [SerializeField] InputAction moveHorizontal;

    private Rigidbody rb;
    // private ForceMode jumpForceMode = ForceMode.Impulse;
    // private bool playerWantsToJump = false;

    void OnEnable()
    {
        moveHorizontal.Enable();
    }

    void OnDisable()
    {
        moveHorizontal.Disable();
        // jump.Enable();

    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        // jump.Disable();

    }

    // private void Update()
    // {
    //     // Keyboard events are checked each frame, so we should check them in Update.
    //     if (jump.WasPressedThisFrame())
    //         playerWantsToJump = true;
    // }
    private void OnValidate()
    {
        // Provide default bindings for the input actions.
        // Based on answer by DMGregory: https://gamedev.stackexchange.com/a/205345/18261
        // if (jump == null)
        //     jump = new InputAction(type: InputActionType.Button);
        // if (jump.bindings.Count == 0)
        //     jump.AddBinding("<Keyboard>/space");
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
    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = moveHorizontal.ReadValue<float>();
        Vector3 movementVector = new Vector3(horizontal, 0, 0) * speed * Time.deltaTime;
        transform.position += movementVector;
    }
}
