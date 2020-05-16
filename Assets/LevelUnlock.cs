using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUnlock : MonoBehaviour
{

    public Drawables levelModels;
    public Levels levels;
    // Start is called before the first frame update
    public bool levelUnlocked;
    public RoomManager roomManager;

    public void Start()
    {
        levelModels = roomManager.currentRoom.RoomPaintables;
    }
    public void unlockLevel()
    {
        levelUnlocked = true;
        for (int i = 0; i < levelModels.drawables.Count; i++)
        {
            levelUnlocked &= levelModels.drawables[i].unlocked;
        }
        levels.levels[levelModels.level-1].LevelCompleted = levelUnlocked;
    }

  
}
