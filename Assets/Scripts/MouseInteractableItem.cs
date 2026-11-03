using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseInteractableItem : MonoBehaviour
{
    MeshRenderer mr;
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    //For this to work item needs a material with emission color selected, but starting as disabled
    void OnMouseOver()
    {
        mr.material.EnableKeyword("_EMISSION");
    }

    void OnMouseExit()
    {
        mr.material.DisableKeyword("_EMISSION");
    }
}
