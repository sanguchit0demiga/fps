using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movementcharactercontroller : MonoBehaviour
{
    private CharacterController controller;
    private bool groundedPlayer;
    private Vector3 PlayerVelocity;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();


    }

    // Update is called once per frame
    void Update()
    {
        groundedPlayer= controller.isGrounded;
        if (groundedPlayer && PlayerVelocity.y < 0 ) 
        {
            PlayerVelocity.y = 0;
    }
        Vector3 move= new Vector3(Input.GetAxis("Horizontal") * -1, 0, Input.GetAxis("Vertical") * -1);
        controller.Move(move* Time.deltaTime*playerSpeed);
         
        if (move!= Vector3.zero) {
            gameObject.transform.forward = move;

            if (Input.GetButtonDown("Jump") && groundedPlayer) {
                PlayerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);


            }
        }
        PlayerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(PlayerVelocity * Time.deltaTime);
    }
}
