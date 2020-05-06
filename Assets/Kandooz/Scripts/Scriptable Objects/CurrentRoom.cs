using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CurrentRoom : ScriptableObject
{
    [SerializeField]
    private RoomCategory value;


    public RoomCategory Value
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

[System.Serializable]
public enum RoomCategory { Room1, Room2 };