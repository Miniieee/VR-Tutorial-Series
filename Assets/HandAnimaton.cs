using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimaton : MonoBehaviour
{
    [Header("Animator Component")]
    [SerializeField] Animator handAnimator;

    [Header("Input action references")]
    [SerializeField] InputActionProperty pinchAction;
    [SerializeField] InputActionProperty gripAction;
    

    private float pinchValue = 0f;
    private float gripValue = 0f;


    private void Update() 
    {
        pinchValue = pinchAction.action.ReadValue<float>();
        gripValue = gripAction.action.ReadValue<float>();

        handAnimator.SetFloat("Trigger", pinchValue);
        handAnimator.SetFloat("Grip", gripValue);
    }
}
