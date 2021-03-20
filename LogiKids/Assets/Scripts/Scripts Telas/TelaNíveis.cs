using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;


public class TelaNíveis : MonoBehaviour
{
    public int FaseAtual = 1;
    public static int UltimaFaseConstatada = 1;
    public int NivelAtual;
    //public TMP_Text TextoDeAjuda;

    private void Update()
    {
        if(UltimaFaseConstatada != 1)
        {
            FaseAtual = UltimaFaseConstatada;
            Textos.FaseAtual = Convert.ToString(FaseAtual);
            Textos.NivelAtual = Convert.ToString(NivelAtual);
        }
    }
    void OnMouseDown()
    {
            Textos.NivelAtual = "0" + Convert.ToString(NivelAtual);
            Textos.FaseAtual = "0" + Convert.ToString(FaseAtual);

            if (NivelAtual == 1)
            {
                if (FaseAtual == 1)
                {
                    Câmera.TagTela = "Help01-01";
                }
                if (FaseAtual == 2)
                {
                    Câmera.TagTela = "Help01-02";
                }
                if (FaseAtual == 3)
                {
                    Câmera.TagTela = "Help01-03"; ;
                }
            }

            if (NivelAtual == 2)
            {
                if (FaseAtual == 1)
                {
                    Câmera.TagTela = "Help02-01";
                }
                if (FaseAtual == 2)
                {
                    Câmera.TagTela = "Help02-02";
                }
                if (FaseAtual == 3)
                {
                    Câmera.TagTela = "Help02-03"; ;
                }
            }

            if (NivelAtual == 3)
            {
                if (FaseAtual == 1)
                {
                    Câmera.TagTela = "Help03-01";
                }
                if (FaseAtual == 2)
                {
                    Câmera.TagTela = "Help03-02";
                }
                if (FaseAtual == 3)
                {
                    Câmera.TagTela = "Help03-03";
                }
            }
    }
}
