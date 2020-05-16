using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Kandooz/BooleanField")]

public class BooleanField : ScriptableObject
{
    [SerializeField]
    private bool value;


    public bool Value
    {


        get
        {
            return value;
        }

        set
        {
            this.value = value;

        }
    }


}

