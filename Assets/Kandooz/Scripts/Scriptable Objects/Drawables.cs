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
    public GameObject model;
    public bool locked;
    public string saveName;
    public int id;
}

[System.Serializable]
public enum ObjectType {None};
