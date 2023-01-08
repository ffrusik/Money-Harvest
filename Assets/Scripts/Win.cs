using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public static bool IsWin = false;

    private void Update()
    {
        if (IsWin)
        {
            Debug.Log("Win");

            SceneManager.LoadScene("Win");
        }
    }
}
