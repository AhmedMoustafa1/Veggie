using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D;

public class RoomManager : MonoBehaviour
{
    public Drawables myDrawables;
    public List<GameObject> roomModels;

    void Start()
    {
        //SetData();
    }

    void SetData()
    {
        for(int i=0; i<roomModels.Count; i++)
        {
            int modelIndex = FindModel(roomModels[i].GetComponent<ModelName>().modelName);

            //add components
            if (roomModels[i].GetComponent<MeshCollider>() == null)
                roomModels[i].AddComponent<MeshCollider>();

            if (roomModels[i].GetComponent<P3dPaintable>() == null)
                roomModels[i].AddComponent<P3dPaintable>();

            if (roomModels[i].GetComponent<P3dPaintableTexture>() == null)
                roomModels[i].AddComponent<P3dPaintableTexture>();

            roomModels[i].GetComponent<P3dPaintableTexture>().SaveName = myDrawables.drawables[modelIndex].saveName;

            if (roomModels[i].GetComponent<P3dMaterialCloner>() == null)
                roomModels[i].AddComponent<P3dMaterialCloner>();
        }
    }

    int FindModel(string modelName)
    {
        for (int i = 0; i < myDrawables.drawables.Count; i++)
        {
            if (modelName == myDrawables.drawables[i].name)
                return i;
        }
        return 0;
    }
}
