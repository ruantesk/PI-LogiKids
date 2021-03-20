using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelaAjuda : MonoBehaviour
{
    private string TagPróximaTela;

    void OnMouseDown()
    {
        TagPróximaTela = Textos.NivelAtual + "-" + Textos.FaseAtual;
        Câmera.TagTela = TagPróximaTela;
    }
}
