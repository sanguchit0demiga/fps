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
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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
        SceneManager.LoadScene("Winn");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void PlayerDefeated()
    {
        SceneManager.LoadScene("lose");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
