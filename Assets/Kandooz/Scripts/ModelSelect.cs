using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelSelect : MonoBehaviour
{
    public bool selected;

    public Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale;
    }

    public void ModelSelected()
    {
        LeanTween.scale(gameObject, originalScale * 1.08f, 0.3f).setLoopPingPong();
    }

    public void ModelUnselected()
    {
        LeanTween.cancel(gameObject);
        LeanTween.scale(gameObject, originalScale, 0.3f);
    }

}
