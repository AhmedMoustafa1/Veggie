using Kandooz;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D;

public class LoadSelectedModel : MonoBehaviour
{
    public IntField selectedID;
    public Drawables myDrawables;
    public Transform loadingPosition;

    void Start()
    {

        int drawableIndex = FindModel(selectedID.Value);

        var currentModel = Instantiate(myDrawables.drawables[drawableIndex].model);
        currentModel.transform.position = loadingPosition.position;
        currentModel.GetComponent<P3dPaintableTexture>().SaveName = myDrawables.drawables[drawableIndex].saveName;
    }



    int FindModel(int id)
    {

        for(int i=0; i<myDrawables.drawables.Count; i++)
        {
            if (id == myDrawables.drawables[i].id)
                return i;
        }
        return 0;
    }


    
}
