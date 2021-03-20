using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelaInicio : MonoBehaviour
{
    void OnMouseDown()
    {
        Câmera.TagTela = "TelaLogin";

        if (PlayerPrefs.GetInt("jogou", 0) == 0)
        {
            Câmera.TagTela = "TelaLogin"; 
        } else
        {
            Câmera.TagTela = "TelaMenu";
        }
    }
}
