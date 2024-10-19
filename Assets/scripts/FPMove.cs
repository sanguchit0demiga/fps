using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPMove : MonoBehaviour
{
    public float playerSpeed = 2.0f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 moveRelative = transform.TransformDirection(move) * playerSpeed*Time.deltaTime; 
        rb.MovePosition(rb.position + moveRelative);

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Cursor.lockState = CursorLockMode.None;
    }
}
}
