using UnityEngine;
using UnityEngine.InputSystem;


public class NewAnimSpinner : MonoBehaviour
{
    public Animator animController;


    // store animator reference using a hash for better performance

    private int isRotatingHash = Animator.StringToHash("IsRotating");






    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animController = GetComponent<Animator>();
    }


    public void ToggleSpin(InputAction.CallbackContext context)
    {
        if (context.performed && animController.GetBool(isRotatingHash) == true)
        {
            // tell animator to spin the cube
            animController.SetBool(isRotatingHash, false);

        }
        else if (context.performed && animController.GetBool(isRotatingHash) == false)
        {
            // tell animator to spin the cube
            animController.SetBool(isRotatingHash, true);

        }
    }

}
