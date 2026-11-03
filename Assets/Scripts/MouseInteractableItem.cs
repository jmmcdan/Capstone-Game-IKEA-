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

    // Update is called once per frame
    void OnMouseOver()
    {
        mr.material.EnableKeyword("_EMISSION");
    }

    void OnMouseExit()
    {
        mr.material.DisableKeyword("_EMISSION");
    }
}
