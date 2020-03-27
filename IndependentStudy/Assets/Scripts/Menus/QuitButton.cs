using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class QuitButton : MonoBehaviour, IPointerClickHandler
{

    //Clicking the menu element
    public void OnPointerClick(PointerEventData eventData)
    {
        Application.Quit();
    }
}
