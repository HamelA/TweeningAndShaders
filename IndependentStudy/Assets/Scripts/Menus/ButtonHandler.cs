using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    //Hover over menu element
    public void OnPointerEnter(PointerEventData eventData)
    {
        ChangeTextScale(1.5f);
    }
 
    //Hover away from menu element
    public void OnPointerExit(PointerEventData eventData)
    {
        ChangeTextScale(1f);
    }

    private void ChangeTextScale(float newScale)
    {
        this.GetComponent<RectTransform>().localScale = new Vector3(newScale, newScale, newScale);
    }
}
