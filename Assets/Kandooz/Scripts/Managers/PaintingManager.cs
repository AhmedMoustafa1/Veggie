using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintingManager : MonoBehaviour
{
    public List<PaintIn3D.Examples.P3dColor> colors;
    public Drawables myDrawables;
    public int currentIndex;

    public List<bool> colorDone = new List<bool>();

    private void Start()
    {
        //myDrawables = GetComponent<LoadSelectedModel>().myDrawables;
        //currentIndex = GetComponent<LoadSelectedModel>().drawableIndex;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            for (int i=0; i<myDrawables.drawables[currentIndex].colors.Count; i++)
            {
                for(int j=0; j<colors.Count; j++)
                {
                    if (myDrawables.drawables[currentIndex].colors[i].name == colors[j].name)
                    {
                        if (colors[j].Solid == myDrawables.drawables[currentIndex].colors[i].colorCount)
                            colorDone.Add(true);
                        else
                            colorDone.Add(false);
                    }
                }
            }


            for(int i=0; i<colorDone.Count; i++)
            {
                if(colorDone[i] == false)
                {
                    Debug.Log("NOT MATCH");
                    break;
                }
                Debug.Log("Match");
            }
        }
    }
}
