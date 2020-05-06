using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D;

public class RoomManager : MonoBehaviour
{
    public Drawables myDrawables;
    public CurrentRoom currentRoom;

    void Start()
    {
        SetData();
    }


    void SetData()
    {

        RoomCategory chosenRoom = currentRoom.Value;

        for (int i = 0; i < myDrawables.drawables.Count; i++)
        {
            if (myDrawables.drawables[i].roomCategory == chosenRoom)
            {
                var currentModel = Instantiate(myDrawables.drawables[i].model);

                currentModel.transform.position = myDrawables.drawables[i].positionInRoom;
                currentModel.transform.localScale = currentModel.transform.localScale * myDrawables.drawables[i].scaleInRoom;
                currentModel.transform.rotation = Quaternion.Euler(myDrawables.drawables[i].rotationInRoom);

                currentModel.tag = "selectable";
            }
        }
    }
}
