﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomButton : MonoBehaviour
{
    public Drawables room; //set by levelsManager
    public CurrentRoom chosenRoom;


    private void Start()
    {
        GetComponent<AnimatedButton>().onClick.AddListener(SetRoom);
    }


    public void SetRoom()
    {
        chosenRoom.RoomPaintables = room;
    }
}
