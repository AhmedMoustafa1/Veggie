using Kandooz;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PaintIn3D;

public class LoadSelectedModel : MonoBehaviour
{
    public StringField selectedID;
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

        currentModel.transform.localScale = currentModel.transform.localScale * myDrawables.drawables[drawableIndex].scaleinDrawingScene;

        if (currentModel.GetComponent<P3dPaintable>())
        {
            Destroy(currentModel.GetComponent<Highlighter>());
            Destroy(currentModel.GetComponent<Selectable>());
            //currentModel.GetComponent<Highlighter>().enabled = false;
            //currentModel.GetComponent<Selectable>().enabled = false;
        }

        else
        {
            GameObject child = currentModel.GetComponentInChildren<MeshRenderer>().gameObject;
            Destroy(child.GetComponent<Highlighter>());
            Destroy(child.GetComponent<Selectable>());
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
