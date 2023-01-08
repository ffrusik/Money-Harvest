using UnityEngine;

public class GraphCompany : MonoBehaviour
{
    public static float CompanyValue;
    public static float ReduceCompanyValue = 0.00125f;

    private void Awake()
    {
        transform.position = new Vector2(transform.position.x, -3.315f);
        CompanyValue = transform.position.y;
    }

    private void Update()
    {
        if (TryAgain.IsTryAgain)
        {
            Try();
        }

        //Debug.Log("Company: " + CompanyValue);
        if (CompanyValue <= -1.5f - 3.315f)
        {
            transform.position = new Vector2(transform.position.x, -1.5f - 3.315f);
            GameOver.IsGameOver = true;
        }
        if (CompanyValue >= 1.5f - 3.315f)
        {
            transform.position = new Vector2(transform.position.x, 1.5f - 3.315f);
            CompanyValue = 1.5f - 3.315f;
        }
    }

    private void FixedUpdate()
    {
        if (!GameOver.IsGameOver)
        {
            CompanyValue -= ReduceCompanyValue;
            transform.position = new Vector2(transform.position.x, CompanyValue);
        }
    }

    private void Try()
    {
        transform.position = new Vector2(transform.position.x, -3.315f);
        CompanyValue = transform.position.y;
        ReduceCompanyValue = 0.001f;
    }

    private void LateUpdate()
    {
        TryAgain.IsTryAgain = false;
    }
}