using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CreditButton : MonoBehaviour, IPointerClickHandler
{
    public GameObject mainMenu;
    public GameObject credits;

    //Clicking the menu element
    public void OnPointerClick(PointerEventData eventData)
    {
        credits.SetActive(true);
        mainMenu.SetActive(false);
    }
}
