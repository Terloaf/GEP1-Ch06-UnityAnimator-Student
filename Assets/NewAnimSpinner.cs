using UnityEngine;
using UnityEngine.InputSystem;


public class NewAnimSpinner : MonoBehaviour
{
    public Animator animController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animController = GetComponent<Animator>();
    }


    public void ToggleSpin(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            // tell animator to spin the cube

            
        }
    }

}
