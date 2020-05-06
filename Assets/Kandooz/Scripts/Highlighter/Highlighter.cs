using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highlighter : MonoBehaviour
{
    public Material highlightMat;

    private Material originalMat;
    private MeshRenderer thisMeshRenderer;
    // Start is called before the first frame update
    private void Awake()
    {
        thisMeshRenderer = this.gameObject.GetComponent<MeshRenderer>();
        originalMat = thisMeshRenderer.material;
    }

  public  void Highlight()
    {
        thisMeshRenderer.material = highlightMat;
    }

   public  void UnHighlight()
    {
        thisMeshRenderer.material = originalMat;

    }

}
