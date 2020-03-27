using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class MenuHandler : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    private bool mouse_over;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mouse_over)
         {
             Debug.Log("Mouse Over");
         }
    }

    public void OnPointerEnter(PointerEventData eventData)
     {
         mouse_over = true;
         Debug.Log("Mouse enter");
     }
 
     public void OnPointerExit(PointerEventData eventData)
     {
         mouse_over = false;
         Debug.Log("Mouse exit");
     }
}
