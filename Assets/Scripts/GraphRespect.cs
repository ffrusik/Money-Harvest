using UnityEngine;

public class GraphRespect : MonoBehaviour
{
    public static float RespectValue;
    public static float AddRespectValue = 0.001f;

    private void Awake()
    {
        transform.position = new Vector2(transform.position.x, 3.315f);
        RespectValue = transform.position.y;
    }

    private void Update()
    {
        if (TryAgain.IsTryAgain)
        {
            Try();
        }

        //Debug.Log("Rep: " + RespectValue);
        if (RespectValue <= -1.5f + 3.315f)
        {
            transform.position = new Vector2(transform.position.x, -1.5f + 3.315f);
            GameOver.IsGameOver = true;
        }
        if (RespectValue >= 1.5f + 3.315f)
        {
            transform.position = new Vector2(transform.position.x, 1.5f + 3.315f);
        }
    }

    private void FixedUpdate()
    {
        if (!GameOver.IsGameOver)
        {
            RespectValue += AddRespectValue;
            transform.position = new Vector2(transform.position.x, RespectValue);
        }
    }

    private void Try()
    {
        transform.position = new Vector2(transform.position.x, 3.315f);
        RespectValue = transform.position.y;
        AddRespectValue = 0.001f;
    }

    private void LateUpdate()
    {
        TryAgain.IsTryAgain = false;
    }
}