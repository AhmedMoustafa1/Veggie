using JetBrains.Annotations;
using Kandooz;
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
    public  void ClearLevels()
    {
        for (int i = 0; i < LevelHolders.Count; i++)
        {
            for (int j = 0; j < LevelHolders[i].transform.childCount; j++)
            {
                Destroy(LevelHolders[i].transform.GetChild(j).gameObject);
            }
        }
    }

    public void CreateLevels()
    {
        int index =0;
        for (int i = 0; i < levels.levels.Length; i++)
        {
            GameObject levelButton;

            if (i ==0 || (levels.levels[i].AdWatched && levels.levels[i - 1].LevelCompleted))
            {
                levelButton = levels.levels[i].unlocked;

            }
            else if (levels.levels[i - 1].LevelCompleted &&!levels.levels[i].AdWatched)
            {
                levelButton = levels.levels[i].watchAd;
            }

            else
            {

                levelButton = levels.levels[i].locked;
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

                level.GetComponent<RoomButton>().room = levels.levels[i].drawable;
               level.GetComponent<RoomButton>().roomNumber = i;
            }
            if (levelButton == levels.levels[i].watchAd)
            {
                level.GetComponent<RoomButton>().roomNumber = i;

            }

        }

    }


    public void SetupLevel()
    {
        ClearLevels();
        CreateLevels();

    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            ClearLevels();

        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            CreateLevels();

        }
    }
}
