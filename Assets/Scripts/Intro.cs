using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    private TextMeshProUGUI _introText;

    [SerializeField] private string[] lines;
    [SerializeField] private float speedOfText;

    private int _index;

    // index 0
    [SerializeField] private GameObject vegetablesForIndex0;

    // index 1
    [SerializeField] private GameObject moneyForIndex1;

    // index 3
    [SerializeField] private GameObject boombleForIndex3;

    private void Awake()
    {
        _introText = GetComponent<TextMeshProUGUI>();
        _introText.text = "";
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
            if (_introText.text == lines[_index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                _introText.text = lines[_index];
            }
        }
    }

    private IEnumerator ShowText(float speed)
    {
        foreach (char c in lines[_index].ToCharArray())
        {
            _introText.text += c;
            yield return new WaitForSeconds(speed);
        }
    }

    private void NextLine()
    {
        IndexesExit();

        if (_index < lines.Length - 1)
        {
            _index++;
            _introText.text = "";

            StartCoroutine(ShowText(speedOfText));
        }
        else
        {
            SceneManager.LoadScene("Tutorial");
        }
    }

    private void IndexesEnter()
    {
        if (_index == 0)
        {
            // SetActive to true
            vegetablesForIndex0.SetActive(true);
        }
        else if (_index == 1)
        {
            moneyForIndex1.SetActive(true);
        }
        else if (_index == 3)
        {
            boombleForIndex3.SetActive(true);
        }
    }

    private void IndexesExit()
    {
        if (_index == 0)
        {
            // SetActive to false, it's already showed and preparing for the next line
            vegetablesForIndex0.SetActive(false);
        }
        else if (_index == 1)
        {
            moneyForIndex1.SetActive(false);
        }
        else if (_index == 3)
        {
            boombleForIndex3.SetActive(false);
        }
    }
}