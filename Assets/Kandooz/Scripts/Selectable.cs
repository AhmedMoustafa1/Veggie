using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Selectable : MonoBehaviour
{
    public UnityEvent OnSelected;
    public UnityEvent OnDeSelected;
    // Start is called before the first frame update
    void Start()
    {
    }


    public void Select()
    {
        OnSelected.Invoke();
    }
   public void DeSelect()
    {
        OnDeSelected.Invoke();
    }
}
