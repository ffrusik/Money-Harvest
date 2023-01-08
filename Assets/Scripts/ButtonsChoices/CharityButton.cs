using UnityEngine;
using UnityEngine.EventSystems;

public class CharityButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject arrows;

    public void OnClick()
    {
        GraphRespect.RespectValue += 0.5f;
        GraphCompany.CompanyValue -= 0.4f;
        GraphFamily.FamilyValue += 0.1f;
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
