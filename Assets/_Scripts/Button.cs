using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private bool _soundOnHover, _scaleOnHover, _highlightOnHover;

    [SerializeField] private Vector3 _sizeToScaleTo;
    private Vector3 originalScale = new Vector3(1f, 1f, 1f);

    void OnEnable(){
        transform.localScale = originalScale;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if(_scaleOnHover) transform.LeanScale(_sizeToScaleTo, 0.1f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(_scaleOnHover) transform.LeanScale(originalScale, 0.1f);
    }

}
