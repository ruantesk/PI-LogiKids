using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonNega : MonoBehaviour
{
    void OnMouseDown()
    {
        gameObject.GetComponentsInParent<Transform>()[1].gameObject.SetActive(false);
    }
}
