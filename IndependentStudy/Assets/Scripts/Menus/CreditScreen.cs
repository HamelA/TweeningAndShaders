using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditScreen : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject credits;
    public Transform newTransform;
    public Transform resetTransform;

    [SerializeField]
    private float time = 20;
    [SerializeField]
    private float delay = 2;

    void OnEnable()
    {
        LeanTween.move(this.gameObject, newTransform, time).setDelay(delay);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            LeanTween.move(this.gameObject, resetTransform, 0.1f);
            mainMenu.SetActive(true);
            credits.SetActive(false);
        }
    }
}
