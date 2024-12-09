using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecieveDamage : MonoBehaviour
{
    public int damage;
    public int health;
    public Slider BarraVidaEnemigo;
    public Transform camaraJugador;
    private void Start()
    {
        BarraVidaEnemigo.maxValue = health;
        BarraVidaEnemigo.value = health;
    }

    private void Update()
    {
        BarraVidaEnemigo.value = health;

        
      
        BarraVidaEnemigo.transform.LookAt(BarraVidaEnemigo.transform.position + camaraJugador.forward);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
        health -= damage;
            
            BarraVidaEnemigo.value=health;  
            Destroy(collision.gameObject);
          
        }
    }
}
    
