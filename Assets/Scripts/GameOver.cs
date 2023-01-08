using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public static bool IsGameOver = false;

    private void Update()
    {
        if (IsGameOver)
        {
            Debug.Log("Game over");

            SceneManager.LoadScene("GameOver");
        }
    }
}