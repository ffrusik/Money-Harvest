using UnityEngine;
using UnityEngine.EventSystems;

public class Off50PercentsButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject arrows;

    public void OnClick()
    {
        GraphCompany.CompanyValue -= 0.2f;
        GraphRespect.RespectValue += 0.35f;
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
