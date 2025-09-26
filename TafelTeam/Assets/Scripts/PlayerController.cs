using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Animations;
public class PlayerController : MonoBehaviour
{
    GameObject cam;
    private CharacterController controller;
    Vector2 moveInput;
    private PlayerControls inputActions;
    public Animator animator;
    [SerializeField] private float speed = 5f;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        inputActions = new PlayerControls();
        controller = GetComponent<CharacterController>();
    }
    //handles the movement
    private void OnEnable()
    {
        inputActions.Enable();
        inputActions.Player.Move.performed += OnMove;
        inputActions.Player.Move.canceled += OnMove;
    }

    private void OnDisable()
    {
        inputActions.Disable();
        inputActions.Player.Move.performed -= OnMove;
        inputActions.Player.Move.canceled -= OnMove;
    }

    private void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();

    }

    private void Update()
    {
        //makes it so that if you are zoomed in you cant move
        if (ZoomCam.camOn == false)
        {

            Vector3 move = new Vector3(moveInput.x, 0f, 0f);
            controller.Move(move * speed * Time.deltaTime);
        }
        else
        {

        }

        // Prevent movement when zoomed in
        if (!ZoomCam.camOn)
        {
            Vector3 move = new Vector3(moveInput.x, 0f, 0f);
            controller.Move(move * speed * Time.deltaTime);
        }
        // Handle animations
        if (moveInput.x == 0f)// Not moving
        {
            animator.SetBool("Idle", true);
        }

        else if (moveInput.x > 0.1f) // Moving right
        {
            animator.SetBool("Right", true);
            animator.SetBool("Left", false);
            animator.SetBool("Idle", false);
        }
        else if (moveInput.x < -0.1f) // Moving left
        {
            animator.SetBool("Right", false);
            animator.SetBool("Left", true);
            animator.SetBool("Idle", false);
        }

    }
}
