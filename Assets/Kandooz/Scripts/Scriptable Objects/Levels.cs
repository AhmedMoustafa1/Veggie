using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Veggie/Levels")]

public class Levels : ScriptableObject
{
    [SerializeField] public Level[] levels;


}
[System.Serializable]
public class Level
{
    public string levelName;
    public int levelId;

    public GameObject locked;
    public GameObject watchAd;

    public GameObject unlocked;

    public bool adWatched = false;
    public bool AdWatched
    {
        get
        {
            if (PlayerPrefs.HasKey("Level ad" + levelId))
            {
                if (PlayerPrefs.GetInt("Level ad" + levelId) == 1)
                {
                    adWatched = true;

                }
                else
                {
                    adWatched = false;

                }
            }
            else
            {
                adWatched = false;
            }
            return adWatched;
        }

        set
        {


            if (PlayerPrefs.HasKey("Level ad" + levelId))
            {
                if (PlayerPrefs.GetInt("Level ad" + levelId) == 1)
                {
                    return;

                }
            }
            this.adWatched = value;

            PlayerPrefs.SetInt("Level ad" + levelId, adWatched ? 1 : 0);
            PlayerPrefs.Save();

        }
    }


    public bool levelCompleted = false;
    public bool LevelCompleted
    {
        get
        {
            if (PlayerPrefs.HasKey("Level complete" + levelId))
            {
                if (PlayerPrefs.GetInt("Level complete" + levelId) == 1)
                {
                    levelCompleted = true;

                }
                else
                {
                    levelCompleted = false;

                }
            }
            else
            {
                levelCompleted = false;
            }
            return levelCompleted;
        }

        set
        {

            if (PlayerPrefs.HasKey("Level complete" + levelId))
            {
                if (PlayerPrefs.GetInt("Level complete" + levelId) == 1)
                {
                    return;

                }
            }
            this.levelCompleted = value;

            PlayerPrefs.SetInt("Level complete" + levelId, levelCompleted ? 1 : 0);
            PlayerPrefs.Save();

        }
    }
    public Drawables drawable;





}