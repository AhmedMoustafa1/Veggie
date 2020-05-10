using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D;

public class RoomManager : MonoBehaviour
{
    public CurrentRoom currentRoom;

    void Start()
    {
        SetData();
    }


    void SetData()
    {
        Drawables chosenRoom = currentRoom.RoomPaintables;

        for (int i = 0; i < chosenRoom.drawables.Count; i++)
        {
            var currentModel = Instantiate(chosenRoom.drawables[i].model);

            currentModel.transform.position = chosenRoom.drawables[i].positionInRoom;
            currentModel.transform.localScale = currentModel.transform.localScale * chosenRoom.drawables[i].scaleInRoom;
            currentModel.transform.rotation = Quaternion.Euler(chosenRoom.drawables[i].rotationInRoom);
        }
    }
}
