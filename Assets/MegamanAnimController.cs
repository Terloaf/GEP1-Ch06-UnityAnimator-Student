using UnityEngine;
using UnityEngine.InputSystem;

public class MegamanAnimController : MonoBehaviour

{


    public Animator animator;

    public Vector2 moveInput;
    public int MoveInputXHash = Animator.StringToHash("MoveInputX");

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();

        animator.SetFloat(MoveInputXHash, moveInput.x);
    }
}
