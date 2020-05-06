using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelsManager : MonoBehaviour
{
    public CurrentRoom currentRoom;

    public LevelsPositions positions;
    public List<GameObject> LevelHolders;

    public Levels levels;

    public void Awake()
    {
            CreateLevels();

    }
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

    public void CreateLevels()
    {
        int index =0;
        for (int i = 0; i < levels.levels.Length; i++)
        {
            GameObject levelButton;
            if (i >0 &&!levels.levels[i].adWatched && !levels.levels[i-1].levelCompleted)
            {
                levelButton = levels.levels[i].locked;
            }
            else
            {
                levelButton = levels.levels[i].unlocked;
            }

            GameObject level;
            if (i<=9)
            {
                level = Instantiate(levelButton, LevelHolders[0].transform);


            }
            else if (i > 9 && i <= 19)
            {
                level = Instantiate(levelButton, LevelHolders[1].transform);


            }
            else if (i > 19 && i >= 19)
            {
                level = Instantiate(levelButton, LevelHolders[2].transform);

            }
            else
            {
                level = new GameObject();
            }
           
            if (i%10 == 0)
            {
                index = 0;
            }
            level.GetComponent<RectTransform>().localPosition = new Vector3(positions.Locations[index].x, positions.Locations[index].y, 0);
            index++;

            if (levelButton == levels.levels[i].unlocked)
            {
                level.GetComponentInChildren<Text>().text = levels.levels[i].levelName;
                if (!levels.levels[i].levelCompleted)
                {
                    level.transform.Find("Stars").gameObject.SetActive(false);
                }
            }
           
        }

    }
}
