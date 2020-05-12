using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LongClickButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{

    public bool longClickButton= false;

    private bool buttonDown = false;
    

    public UnityEvent pressButton;
    public UnityEvent clickButton;
    public Image image;
    public Color tintColor;

    void Update()
    {
        if (buttonDown)
        {

            pressButton.Invoke();
        }
    }
   

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonDown = true;
        HighlightButton();
        if (!longClickButton)
        {
            clickButton.Invoke();
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonDown = false;
        UnHighlightButton();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonDown = false;
        UnHighlightButton();
    }



   private void HighlightButton()
   {
        image.color = tintColor;
   }


    private void UnHighlightButton()
    {
        image.color = Color.white;
    }
}

