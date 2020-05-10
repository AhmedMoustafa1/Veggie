using Kandooz;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D;

public class LoadSelectedModel : MonoBehaviour
{
    public StringField selectedModel;
    public CurrentRoom chosenRoom;
    public Transform loadingPosition;

    private Drawables myDrawables;
    private GameObject currentModel;

    void Start()
    {
        myDrawables = chosenRoom.RoomPaintables;
        SetData();
    }

    void SetData()
    {
        int drawableIndex = FindModel(selectedModel.Value);

        currentModel = Instantiate(myDrawables.drawables[drawableIndex].model);
        currentModel.transform.position = loadingPosition.position;

        currentModel.transform.localScale = currentModel.transform.localScale * myDrawables.drawables[drawableIndex].scaleinDrawingScene;

        if (currentModel.GetComponent<P3dPaintable>())
        {
            Destroy(currentModel.GetComponent<Selectable>());
        }

        else
        {
            GameObject child = currentModel.GetComponentInChildren<MeshRenderer>().gameObject;
            Destroy(child.GetComponent<Selectable>());
            //child.GetComponent<Selectable>().enabled = false;
        }
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
