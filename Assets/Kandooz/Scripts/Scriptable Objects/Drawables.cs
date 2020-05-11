using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Drawables : ScriptableObject
{
    public List<DrawableInfo> drawables;
}


[System.Serializable]
public class DrawableInfo
{
    public string name;
    public bool unlocked;
    public GameObject model;
    public RoomCategory roomCategory;
    public string saveName;

    public Vector3 positionInRoom;
    public Vector3 rotationInRoom;
    public float scaleInRoom;
    public float scaleinDrawingScene;

    public List<ColorsInfo> colors;
}

[System.Serializable]
public class ColorsInfo
{
    public string name;
    public int colorCount;
}


