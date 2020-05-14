using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaintingManager : MonoBehaviour
{
    public List<PaintIn3D.Examples.P3dColor> colors;

    public Text matchingTxt;

    private Drawables myDrawables;
    private int currentIndex;

    private List<bool> colorDone;


    public void LateStart()
    {
        myDrawables = GetComponent<LoadSelectedModel>().myDrawables;
        currentIndex = GetComponent<LoadSelectedModel>().drawableIndex;
    }

    public void CompareModels()
    {
        colorDone = new List<bool>();
        List<ColorsInfo> colorsInfo = myDrawables.drawables[currentIndex].colors;

        for (int i = 0; i < colorsInfo.Count; i++)
        {
            for (int j = 0; j < colors.Count; j++)
            {
                if (colorsInfo[i].name == colors[j].name)
                {
                    if (colorsInfo[i].colorCount + 1000 > colors[j].Solid && colors[j].Solid >= colorsInfo[i].colorCount || colorsInfo[i].colorCount >= colors[j].Solid && colors[j].Solid > colorsInfo[i].colorCount-1000)
                        colorDone.Add(true);
                    else
                        colorDone.Add(false);
                }
            }
        }


        for (int i = 0; i < colorDone.Count; i++)
        {
            if (colorDone[i] == false)
            {
                Debug.Log("NOT MATCH");
                matchingTxt.text = "Try Again";
                StartCoroutine(wait());
                return;
            }
            
        }
        myDrawables.drawables[currentIndex].unlocked = true;
        Debug.Log("Match");
        matchingTxt.text = "Well Done";
        StartCoroutine(wait());
    }


    IEnumerator wait()
    {
        yield return new WaitForSeconds(2);
        matchingTxt.text = "";
    }
}
