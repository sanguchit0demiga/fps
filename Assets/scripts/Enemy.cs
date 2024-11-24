using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public ParticleSystem deathParticles;
    // Start is called before the first frame update
    public Score sumarScore;
    public int health = 3;
    private GameController gameController;
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        if (sumarScore == null)
        {
            sumarScore= FindObjectOfType<Score>();
        }

 
   

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health -= 1;
            Destroy(collision.gameObject);
          if (health <= 0) {
                Die();
        }
    }
    void Die()
    {
            gameController.EnemyDefeated();
            sumarScore.Contador(1);
        Destroy(gameObject);
            Instantiate(deathParticles, transform.position, Quaternion.identity);

    }

}

}