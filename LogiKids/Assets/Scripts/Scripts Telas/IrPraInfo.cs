using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class IrPraInfo : MonoBehaviour
{
    void OnMouseDown()
    {
          if (Textos.NivelAtual == "01")
            {
                if (Textos.FaseAtual == "01")
                {
                    Câmera.TagTela = "Info01-01";
                }
                if (Textos.FaseAtual == "02")
                {
                    Câmera.TagTela = "Info01-02";
                }
                if (Textos.FaseAtual == "03")
                {
                    Câmera.TagTela = "Info01-03";
                }
            }

            if (Textos.NivelAtual == "02")
            {
                if (Textos.FaseAtual == "01")
                {
                    Câmera.TagTela = "Info02-01";
                }
                if (Textos.FaseAtual == "02")
                {
                    Câmera.TagTela = "Info02-02";
                }
                if (Textos.FaseAtual == "03")
                {
                    Câmera.TagTela = "Info02-03";
                }
            }

            if (Textos.NivelAtual == "03")
            {
                if (Textos.FaseAtual == "01")
                {
                    Câmera.TagTela = "Info03-01";
                }
                if (Textos.FaseAtual == "02")
                {
                    Câmera.TagTela = "Info03-02";
                }
                if (Textos.FaseAtual == "03")
                {
                    Câmera.TagTela = "Info03-03";
                }
            }
    }
}
