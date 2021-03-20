using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TelaInfo : MonoBehaviour
{
    public GameObject Alerta;

    private void OnMouseDown()
    {
        Alerta.SetActive(true);
    }
}
