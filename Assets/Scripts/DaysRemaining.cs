using System.Collections;
using UnityEngine;
using TMPro;

public class DaysRemaining : MonoBehaviour
{
    private TextMeshProUGUI _daysText;
    public static int Days;

    private void Awake()
    {
        _daysText = GetComponent<TextMeshProUGUI>();
        Days = 60;
        _daysText.text = Days + " days";
    }

    private void Update()
    {
        if (TryAgain.IsTryAgain)
        {
            Days = 60;
        }

        _daysText.text = Days + " days";

        if (Days == 0)
        {
            Win.IsWin = true;
        }
    }

    private void Start()
    {
        StartCoroutine(DaysGoes());
    }

    private void LateUpdate()
    {
        TryAgain.IsTryAgain = false;
    }

    private IEnumerator DaysGoes()
    {
        while (Days != 0)
        {
            yield return new WaitForSeconds(1);
            Days -= 1;
        }
    }
}
