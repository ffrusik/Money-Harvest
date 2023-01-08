using UnityEngine;

public class RespectButton : MonoBehaviour
{
    [SerializeField] private GameObject CompanyPanel;
    [SerializeField] private GameObject FamilyPanel;

    public void OnClick()
    {
        gameObject.SetActive(true);
        CompanyPanel.SetActive(false);
        FamilyPanel.SetActive(false);
    }
}
