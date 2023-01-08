using UnityEngine;
using UnityEngine.EventSystems;

public class ScamButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject arrows;

    public void OnClick()
    {
        GraphCompany.CompanyValue += 0.8f;
        GraphRespect.RespectValue -= 0.5f;
        GraphFamily.FamilyValue -= 0.1f;
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
