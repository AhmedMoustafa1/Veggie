using PaintIn3D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrushSizeAdjuster : MonoBehaviour
{


    public void SetBrushSize(int brushSize)
    {
        var children = GetComponentsInChildren<P3dPaintSphere>(true);
        for (int i = 0; i < children.Length; i++)
        {
            children[i].Scale = brushSize*Vector3.one;
            children[i].Hardness = brushSize;

        }
    }
}
