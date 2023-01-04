using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RotatingCube : MonoBehaviour
{
    public Vector3 editRotation;
    public Keyboard keyboard;

    // Start is called before the first frame update
    void Start()
    {
        keyboard = Keyboard.current;
    }

    // Update is called once per frame
    void Update()
    {
        if (keyboard == null)
        {
            Debug.Log("No Keyboard");
            return;
        }

        if (keyboard.wKey.isPressed)
        {
            transform.Rotate(editRotation * Time.deltaTime);
            Debug.Log(transform.position);
        }
    }
}
