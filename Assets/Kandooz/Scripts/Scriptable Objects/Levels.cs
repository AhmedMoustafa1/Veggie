using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Veggie/Levels")]

public class Levels : ScriptableObject
{
    [SerializeField]public Level[] levels;


}
 [System.Serializable]
public class Level
{
    public string levelName;
    public int levelId;

    public GameObject locked;
    public GameObject unlocked;

    public bool adWatched= false;
    public bool levelCompleted=false;
    public Drawables drawable;

    public void CompleteLevel()
    {
        PlayerPrefs.SetInt("Level Complete" + levelId, levelCompleted ? 1 : 0);
        PlayerPrefs.Save();
    }
    public void WatchedAd()
    {
        PlayerPrefs.SetInt("Level ad" + levelId, levelCompleted ? 1 : 0);
        PlayerPrefs.Save();
    }


}