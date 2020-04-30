using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadSelectedModel : MonoBehaviour
{
    public int selectedID;
    public Drawables myDrawables;
    public Transform loadingPosition;

    void Start()
    {

        int drawableIndex = FindModel(selectedID);

        var currentModel = Instantiate(myDrawables.drawables[drawableIndex].model);
        currentModel.transform.position = loadingPosition.position;
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
