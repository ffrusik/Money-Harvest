using UnityEngine;
using UnityEngine.EventSystems;

public class SpendTimeWithFamilyButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject arrows;

    public void OnClick()
    {
        GraphFamily.FamilyValue += 0.4f;
        GraphCompany.CompanyValue -= 0.25f;
        GraphFamily.ReduceFamilyValue /= 1.05f;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        arrows.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        arrows.SetActive(false);
    }
}