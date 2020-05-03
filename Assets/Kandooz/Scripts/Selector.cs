using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour
{
    public string selectable = "selectable";
    [SerializeField]private Transform currentSelected;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        //Debug.Log(ray.origin);
        if (Physics.Raycast(ray, out hit,100f))
        {
            if (hit.transform.CompareTag(selectable))
            {
                if (currentSelected == null)
                {
                    if (Input.GetButtonDown("Fire1"))
                    {
                        currentSelected = hit.transform;
                        currentSelected.GetComponent<Selectable>().Select();

                    }
                }
                else
                {
                    if (hit.transform != currentSelected)
                    {
                        if (Input.GetButtonDown("Fire1"))
                        {
                            currentSelected.GetComponent<Selectable>().DeSelect();

                            currentSelected = hit.transform;
                            currentSelected.GetComponent<Selectable>().Select();

                        }
                    }
                 
                }
            }


        }
    }
}

