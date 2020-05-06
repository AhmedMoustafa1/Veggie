using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    public GameObject locked;
    public GameObject unlocked;
    public string levelName;
    public int levelId;

    public bool adWatched;
    public bool levelCompleted;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CompleteLevel()
    {
        PlayerPrefs.SetInt("Level Complete"+ levelId, levelCompleted ? 1 : 0);
        PlayerPrefs.Save();
    }
    public void WatchedAd()
    {
        PlayerPrefs.SetInt("Level ad" + levelId, levelCompleted ? 1 : 0);
        PlayerPrefs.Save();
    }
}
