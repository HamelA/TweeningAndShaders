using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    private bool mouseHovering;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        mouseHovering = true;
        ChangeTextScale(1.5f);
    }
 
    public void OnPointerExit(PointerEventData eventData)
    {
        mouseHovering = false;
        ChangeTextScale(1f);
    }

    private void ChangeTextScale(float newScale)
    {
        this.GetComponent<RectTransform>().localScale = new Vector3(newScale, newScale, newScale);
    }
}
