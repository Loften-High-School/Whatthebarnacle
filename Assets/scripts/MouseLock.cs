using UnityEngine;

public class MouseLock : MonoBehaviour
{
    bool locked;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        locked = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        if (locked)
        {
            if (Input.GetKeyDown (KeyCode.Escape))
            {
                locked = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }

        else{
            if (Input.GetMouseButtonDown (0))
            {
                   locked = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
