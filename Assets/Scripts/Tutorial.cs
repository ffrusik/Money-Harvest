using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    private TextMeshProUGUI _tutorialText;

    [SerializeField] private string[] lines;
    [SerializeField] private float speedOfText;

    private int _index;

    // index 0
    [SerializeField] private GameObject arrowsForIndex0;

    // index 1
    [SerializeField] private GameObject arrowsForIndex1;

    // index 3
    [SerializeField] private GameObject arrowsForIndex3;
    [SerializeField] private GameObject companyPanel;

    // index 4
    [SerializeField] private GameObject arrowForIndex4;

    private void Awake()
    {
        _tutorialText = GetComponent<TextMeshProUGUI>();
        _tutorialText.text = "";
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
            if (_tutorialText.text == lines[_index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                _tutorialText.text = lines[_index];
            }
        }
    }

    private IEnumerator ShowText(float speed)
    {
        foreach (char c in lines[_index].ToCharArray())
        {
            _tutorialText.text += c;
            yield return new WaitForSeconds(speed);
        }
    }

    private void NextLine()
    {
        IndexesExit();

        if (_index < lines.Length - 1)
        {
            _index++;
            _tutorialText.text = "";

            StartCoroutine(ShowText(speedOfText));
        }
        else
        {
            SceneManager.LoadScene("Main");
        }
    }

    private void IndexesEnter()
    {
        if (_index == 0)
        {
            // SetActive to true
            arrowsForIndex0.SetActive(true);
        }
        else if (_index == 1)
        {
            arrowsForIndex1.SetActive(true);
        }
        else if (_index == 3)
        {
            arrowsForIndex3.SetActive(true);
            companyPanel.SetActive(true);
        }
        else if (_index == 4)
        {
            arrowForIndex4.SetActive(true);
        }
    }

    private void IndexesExit()
    {
        if (_index == 0)
        {
            // SetActive to false, it's already showed and preparing for the next line
            arrowsForIndex0.SetActive(false);
        }
        else if (_index == 1)
        {
            arrowsForIndex1.SetActive(false);
        }
        else if (_index == 3)
        {
            arrowsForIndex3.SetActive(false);
            companyPanel.SetActive(false);
        }
        else if (_index == 4)
        {
            arrowForIndex4.SetActive(false);
        }
    }
}