using Kandooz;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PaintIn3D;

public class LoadSelectedModel : MonoBehaviour
{
    public StringField selectedModel;
    public CurrentRoom chosenRoom;
    public Image modelImg;
    public Transform loadingPosition;
    public GameObject paintableParent;
    public int drawableIndex;
    public Drawables myDrawables;

    private GameObject currentModel;

    void Start()
    {
        myDrawables = chosenRoom.RoomPaintables;
        SetData();
    }

    void SetData()
    {
        drawableIndex = FindModel(selectedModel.Value);

        GetComponent<PaintingManager>().LateStart();

        currentModel = Instantiate(myDrawables.drawables[drawableIndex].model);
        currentModel.transform.parent = paintableParent.transform;
        currentModel.transform.position = loadingPosition.position;

        currentModel.transform.localScale = currentModel.transform.localScale * myDrawables.drawables[drawableIndex].scaleinDrawingScene;

        modelImg.sprite = myDrawables.drawables[drawableIndex].modelSprite;



        if (currentModel.GetComponent<P3dPaintable>())
        {
            Destroy(currentModel.GetComponent<Selectable>());
        }

        else
        {
            GameObject child = currentModel.GetComponentInChildren<MeshRenderer>().gameObject;
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
