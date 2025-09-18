using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 3f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            controller.Move(Vector3.forward * Time.deltaTime * speed);
            transform.LookAt(transform.position + new Vector3(0, 0, 1));
        }
        else if (Keyboard.current.sKey.isPressed)
        {
            controller.Move(Vector3.back * Time.deltaTime * speed);
            transform.LookAt(transform.position + new Vector3(0, 0, -1));
        }
        else if (Keyboard.current.aKey.isPressed)
        {
            controller.Move(Vector3.left * Time.deltaTime * speed);
            transform.LookAt(transform.position + new Vector3(-1, 0, 0));
        }
        else if (Keyboard.current.dKey.isPressed)
        {
            controller.Move(Vector3.right * Time.deltaTime * speed);
            transform.LookAt(transform.position + new Vector3(1, 0, 0));
        }
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Finish"))
        {
            Debug.Log("Player reached the Finish!");
        }
    }


}
