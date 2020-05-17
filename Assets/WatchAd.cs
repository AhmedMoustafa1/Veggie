using Kandooz;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchAd : MonoBehaviour
{
    public Levels gameLevels;
    public IntField currentSelectedLevel;
    public GameEvent UpdateLevel;
    public void Start()
    {
        //PlayerPrefs.DeleteAll();
        gameLevels.levels[0].AdWatched = true;
    }
    // Start is called before the first frame update
    public void adWatched()
    {

        gameLevels.levels[currentSelectedLevel.Value].AdWatched = true;

        UpdateLevel.Raise();
    }
}
