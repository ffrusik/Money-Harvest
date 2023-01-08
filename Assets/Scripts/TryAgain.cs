using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgain : MonoBehaviour
{
    public static bool IsTryAgain = false;

    public void OnClick()
    {
        GameOver.IsGameOver = false;
        Win.IsWin = false;
        IsTryAgain = true;
        SceneManager.LoadScene("Main");
    }
}
