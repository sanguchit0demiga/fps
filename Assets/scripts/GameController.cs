using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int totalEnemies;
    void Start()
    {
        totalEnemies = FindObjectsOfType<Enemy>().Length;
    }

    // Update is called once per frame
    public void EnemyDefeated()
    {
        totalEnemies--;
        if (totalEnemies<= 0)
        {
            GanarJuego();
        }
}
    void GanarJuego()
    {
        SceneManager.LoadScene(2);
    }
    public void PlayerDefeated()
    {
        SceneManager.LoadScene(3);
    }
}
