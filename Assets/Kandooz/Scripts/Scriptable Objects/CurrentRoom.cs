using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class CurrentRoom : ScriptableObject
{
    [SerializeField]
    private Drawables roomPaintables;

    public Drawables RoomPaintables { get => roomPaintables; set => roomPaintables = value; }
}

[System.Serializable]
public enum RoomCategory { Room1, Room2 };