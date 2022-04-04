using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandController : MonoBehaviour
{
    [SerializeField] InputActionReference gripInputActionRef;
    [SerializeField] InputActionReference triggerInputActionRef;

    Animator _handAnimator;

    private void Awake()
    {
        _handAnimator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        gripInputActionRef.action.performed += GripPressed;
        triggerInputActionRef.action.performed += TriggerPressed;
    }

    private void TriggerPressed(InputAction.CallbackContext obj)
    {
        _handAnimator.SetFloat("Trigger", obj.ReadValue<float>());
    }

    private void GripPressed(InputAction.CallbackContext obj)
    {
        _handAnimator.SetFloat("Grip",obj.ReadValue<float>());
    }

    private void OnDisable()
    {
        gripInputActionRef.action.performed -= GripPressed;
        triggerInputActionRef.action.performed -= TriggerPressed;
    }
}
