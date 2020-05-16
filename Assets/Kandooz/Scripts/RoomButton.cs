using Kandooz;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomButton : MonoBehaviour
{

    public int roomNumber;
    public Drawables room; //set by levelsManager
    public CurrentRoom chosenRoom;
    public IntField currentRoom;

    private void Start()
    {
        GetComponent<AnimatedButton>().onClick.AddListener(SetRoom);
    }


    public void SetRoom()
    {
        chosenRoom.RoomPaintables = room;
    }

    public void SetCurrentRoom()
    {
        currentRoom.Value = roomNumber;
    }
}
