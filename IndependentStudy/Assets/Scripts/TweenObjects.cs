using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenObjects : MonoBehaviour
{

    [SerializeField] private GameObject objectOne;
    [SerializeField] private GameObject objectTwo;
    [SerializeField] private GameObject objectThree;
    [SerializeField] private GameObject objectFour;
    [SerializeField] private GameObject objectFive;
    public LeanTweenType easeTypeOne;
    public LeanTweenType easeTypeTwo;
    public LeanTweenType easeTypeThree;
    public LeanTweenType easeTypeFour;
    public AnimationCurve curve;

    private void OnEnable()
    {
        LeanTween.moveY(objectOne, -5f, 2f).setLoopPingPong().setEase(easeTypeOne);
        LeanTween.moveY(objectTwo, 3f, 1f).setLoopPingPong().setEase(easeTypeTwo);
        LeanTween.moveY(objectThree, 2f, 2f).setLoopPingPong().setEase(easeTypeThree);
        LeanTween.moveY(objectFour, 5f, 4f).setLoopPingPong().setEase(easeTypeFour);
        LeanTween.moveY(objectFive, -6f, 3f).setLoopPingPong().setEase(curve);
    }
}
