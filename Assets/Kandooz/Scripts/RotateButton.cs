using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateButton : MonoBehaviour
{

    public GameObject cameraRotation;
    public Toggle rotateBtn;

    private bool rotationEnabled;

    public bool RotationEnabled
    {
        get
        { return rotationEnabled; }
        set
        {
            rotationEnabled = value;
            //rotateBtn.interactable = !rotateBtn.interactable;
        }
    }

    void Start()
    {
        RotationEnabled = false;
    }


    public void ChangeState()
    {
        RotationEnabled = !RotationEnabled;

        if(RotationEnabled == true) //enable rotation
        {
            cameraRotation.GetComponent<PaintIn3D.Examples.P3dDragPitchYaw>().enabled = true;
        }

        else //disable rotation
        {
            cameraRotation.GetComponent<PaintIn3D.Examples.P3dDragPitchYaw>().enabled = false;
        }
    }
}
