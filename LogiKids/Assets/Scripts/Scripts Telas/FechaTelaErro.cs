using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FechaTelaErro : MonoBehaviour
{
    public GameObject Alerta;
    public string TagAjuda;

    void OnMouseDown()
    {
        Alerta.SetActive(false);
        Câmera.TagTela = TagAjuda;
    }
}
