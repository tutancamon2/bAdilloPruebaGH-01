using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class RightHandController : MonoBehaviour
{
    [Space(20)]
    [Header("Referencias de los componentes del control Derecho ::::: RightController - Grab")]
    [Space(10)]

    public XRRayInteractor xrRayInteractor_grab;
    //public XRInteractorLineVisual xrInteractorLineVisual_grap;

    [Space(20)]
    [Header("Referencias de los componentes del control derecho::::: RightController - Teleport")]
    [Space(10)]
    public XRRayInteractor xrRayInteractor_teleport;
    public XRInteractorLineVisual xrInteractorLineVisual_teleport;

    [Space(20)]
    [Header("Referencia XR Default Input Action ::::: JoyStick - Sector Norte")]
    [Space(10)]
    public InputActionReference JoyStickSectorNorte;

    private void JoyStickArribaPresionado(InputAction.CallbackContext context)
    {
        // grab
        xrRayInteractor_grab.enabled = false;

        // teleport
        xrRayInteractor_teleport.enabled = true;
    }

    private void JoyStickArribaLiberado(InputAction.CallbackContext context) => Invoke("JoyStickArribaLiberado_Invoke",0.01f);

    private void JoyStickArribaLiberado_Invoke()
    {
        // grab
        xrRayInteractor_grab.enabled = true;

        // teleport
        xrRayInteractor_teleport.enabled = false;
    }

    private void OnEnable()
    {
        JoyStickSectorNorte.action.performed += JoyStickArribaPresionado;
        JoyStickSectorNorte.action.canceled += JoyStickArribaLiberado;
    }

   
}
