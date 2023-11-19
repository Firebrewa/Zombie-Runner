using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera fpsCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomOutSensitivty = 2f;
    [SerializeField] float zoomInSensitivty = 0.5f;
    StarterAssets.FirstPersonController fpsController;

    bool zoomedInToggle = false;

    private void OnDisable() 
    {
        ZoomOut();
    }

    private void Update() 
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle == false)
            {
                ZoomIn();

            }
            else
            {
                ZoomOut();
            }
        }

    }

    private void ZoomOut()
    {
        zoomedInToggle = false;
        fpsCamera.m_Lens.FieldOfView = zoomedOutFOV;
        fpsController.RotationSpeed = zoomOutSensitivty;
    }

    private void ZoomIn()
    {
        zoomedInToggle = true;
        fpsCamera.m_Lens.FieldOfView = zoomedInFOV;
        fpsController.RotationSpeed = zoomInSensitivty;
    }
}
