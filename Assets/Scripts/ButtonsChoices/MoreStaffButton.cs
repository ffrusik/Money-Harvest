using UnityEngine;
using UnityEngine.EventSystems;

public class MoreStaffButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject arrows;

    public void OnClick()
    {
        GraphCompany.CompanyValue -= 0.2f;
        GraphCompany.ReduceCompanyValue /= 1.15f;
        GraphRespect.RespectValue += 0.1f;
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
