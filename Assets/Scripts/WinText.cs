using System.Collections;
using UnityEngine;
using TMPro;

public class WinText : MonoBehaviour
{
    private TextMeshProUGUI _winText;

    [SerializeField] private string[] lines;
    [SerializeField] private float speedOfText;

    private int _index;

    // index 0
    [SerializeField] private GameObject boombleForIndex0;

    private void Awake()
    {
        _winText = GetComponent<TextMeshProUGUI>();
        _winText.text = "";
        _index = 0;
    }

    private void Start()
    {
        StartCoroutine(ShowText(speedOfText));
    }

    private void Update()
    {
        IndexesEnter();

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            if (_winText.text == lines[_index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                _winText.text = lines[_index];
            }
        }
    }

    private IEnumerator ShowText(float speed)
    {
        foreach (char c in lines[_index].ToCharArray())
        {
            _winText.text += c;
            yield return new WaitForSeconds(speed);
        }
    }

    private void NextLine()
    {
        IndexesExit();

        if (_index < lines.Length - 1)
        {
            _index++;
            _winText.text = "";

            StartCoroutine(ShowText(speedOfText));
        }
    }

    private void IndexesEnter()
    {
        if (_index == 0)
        {
            // SetActive to true
            boombleForIndex0.SetActive(true);
        }
    }

    private void IndexesExit()
    {
        if (_index == 0)
        {
            // SetActive to false, it's already showed and preparing for the next line
            boombleForIndex0.SetActive(false);
        }
    }
}