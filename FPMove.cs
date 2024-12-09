using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPMove : MonoBehaviour
{
    public float playerSpeed = 2.0f;
    private Rigidbody rb;
    public int health = 3;  
    public Barradevida barraVida;  
    public Score sumarScore;
    private GameController gameController;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        gameController = FindObjectOfType<GameController>();


        if (barraVida != null)
        {
            barraVida.vidaMax = health;
            barraVida.vidaActual = health;
            barraVida.ActualizarBarra();
        }
    }

    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 moveRelative = transform.TransformDirection(move) * playerSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + moveRelative);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            health--;
            if (barraVida != null)
            {
                barraVida.vidaActual = health;
                barraVida.ActualizarBarra();
            }

            if (health <= 0)
            {
                if (gameController != null)
                {
                    gameController.PlayerDefeated();
                }
               
            }
        }
    }
}
