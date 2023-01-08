using UnityEngine;

public class FamilyButton : MonoBehaviour
{
    [SerializeField] private GameObject CompanyPanel;
    [SerializeField] private GameObject RespectPanel;

    public void OnClick()
    {
        gameObject.SetActive(true);
        CompanyPanel.SetActive(false);
        RespectPanel.SetActive(false);
    }
}
