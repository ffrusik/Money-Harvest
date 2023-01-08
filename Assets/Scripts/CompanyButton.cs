using UnityEngine;

public class CompanyButton : MonoBehaviour
{
    [SerializeField] private GameObject FamilyPanel;
    [SerializeField] private GameObject RespectPanel;

    public void OnClick()
    {
        gameObject.SetActive(true);
        FamilyPanel.SetActive(false);
        RespectPanel.SetActive(false);
    }
}
