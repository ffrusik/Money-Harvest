using UnityEngine;

public class GraphFamily : MonoBehaviour
{
    public static float FamilyValue;
    public static float ReduceFamilyValue = 0.0025f;

    private void Awake()
    {
        FamilyValue = transform.position.y;
    }

    private void Update()
    {
        if (TryAgain.IsTryAgain)
        {
            Try();
        }

        //Debug.Log("Family: " + FamilyValue);
        if (FamilyValue <= -1.5f)
        {
            transform.position = new Vector2(transform.position.x, -1.5f);
            GameOver.IsGameOver = true;
        }
        if (FamilyValue >= 1.5f)
        {
            transform.position = new Vector2(transform.position.x, 1.5f);
            FamilyValue = 1.5f;
        }
    }

    private void FixedUpdate()
    {
        if (!GameOver.IsGameOver)
        {
            FamilyValue -= ReduceFamilyValue;
            transform.position = new Vector2(transform.position.x, FamilyValue);
        }
    }

    private void Try()
    {
        transform.position = new Vector2(transform.position.x, 0);
        FamilyValue = transform.position.y;
        ReduceFamilyValue = 0.001f;
    }

    private void LateUpdate()
    {
        TryAgain.IsTryAgain = false;
    }
}