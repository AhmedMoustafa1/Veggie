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

    private GameObject currentModel;

    void Start()
    {
        SetData();
    }

    void SetData()
    {
        int drawableIndex = FindModel(selectedID.Value);

        currentModel = Instantiate(myDrawables.drawables[drawableIndex].model);
        currentModel.transform.position = loadingPosition.position;

        //add components
        if(currentModel.GetComponent<MeshCollider>() == null)
            currentModel.AddComponent<MeshCollider>();

        if (currentModel.GetComponent<P3dPaintable>() == null)
            currentModel.AddComponent<P3dPaintable>();

        if (currentModel.GetComponent<P3dPaintableTexture>() == null)
            currentModel.AddComponent<P3dPaintableTexture>();

        currentModel.GetComponent<P3dPaintableTexture>().SaveName = myDrawables.drawables[drawableIndex].saveName;

        if (currentModel.GetComponent<P3dMaterialCloner>() == null)
            currentModel.AddComponent<P3dMaterialCloner>();
    }


    int FindModel(string id)
    {
        for(int i=0; i<myDrawables.drawables.Count; i++)
        {
            if (id == myDrawables.drawables[i].name)
                return i;
        }
        return 0;
    }


    

    
}
