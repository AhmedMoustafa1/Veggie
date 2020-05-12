using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{

    public Vector3 localRotationSpeed;
    public Vector3 worldRotationSpeed;
    public bool unscaledTime;




    public void Rotate(int direction)
    {
        
        float deltaTime = !unscaledTime ? Time.deltaTime : Time.unscaledDeltaTime;

        if (localRotationSpeed != Vector3.zero)
        {
            transform.Rotate(direction*localRotationSpeed * deltaTime, Space.Self);
        }

        if (worldRotationSpeed != Vector3.zero)
        {
            transform.Rotate(direction*worldRotationSpeed * deltaTime, Space.World);
        }
    }





}
