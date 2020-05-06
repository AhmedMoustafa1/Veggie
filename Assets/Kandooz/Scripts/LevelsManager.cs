using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelsManager : MonoBehaviour
{
    public CurrentRoom currentRoom;

    public void SendRoomData(int categoryNum)
    {
        switch (categoryNum)
        {
            case 1:
                currentRoom.Value = RoomCategory.Room1;
                break;
            case 2:
                currentRoom.Value = RoomCategory.Room2;
                break;
            default:
                currentRoom.Value = RoomCategory.Room1;
                break;
        }
    }

}
