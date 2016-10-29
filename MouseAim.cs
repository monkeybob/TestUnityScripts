using UnityEngine;
using System.Collections;

public class MouseAim : MonoBehaviour {
    // Script to handle crosshair movement with mouse and joystick
    public float JoystickSpeed = 50.0F;
    float currX;
    float currY;
    public bool joystick = true;

    void Start ()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        //Cursor.visible = false;
    }

    // Update is called once per frame
    void Update () {
        if (joystick)
        {
            // Allows crosshair to move with mouse or right thumb stick on a controller
            float moveY = (Input.GetAxis("RVertical") + Input.GetAxis("Mouse Y")) * JoystickSpeed;
            float moveX = (Input.GetAxis("RHorizontal") + Input.GetAxis("Mouse X")) * JoystickSpeed;
            moveX *= Time.deltaTime;
            moveY *= Time.deltaTime;
            currX = currX + moveX;
            currY = currY + moveY;

            transform.position = new Vector2(currX, currY);
        }
        else
        {
            // Puts crosshair at mouse pointer position
            Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pz.z = 0;
            transform.position = pz;
        }

        // Back to menu
        if (Input.GetButtonDown("Cancel"))
        {
            //Cursor.lockState = CursorLockMode.None;
            //Cursor.visible = true;
            Application.LoadLevel("Menu");
        }

        // Reset level
        if (Input.GetButtonDown("Reset"))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
