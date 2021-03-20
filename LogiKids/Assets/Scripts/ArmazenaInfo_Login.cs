using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class ArmazenaInfo_Login : MonoBehaviour
{
    private int Ultimo_Ajudante = 0;
    public static string NomeJogador = "";
    public static int Ajudante = 0;

    public GameObject Ajudante_01;
    public GameObject Ajudante_02;
    public GameObject Ajudante_03;
    public GameObject Ajudante_04;
    public TMP_Text NomeIncentivo;

    private void Update()
    {
        if (Ultimo_Ajudante != Ajudante)
        {
            Ultimo_Ajudante = Ajudante;
            if (Ajudante == 1)
            {
                Ajudante_01.SetActive(true);
                Ajudante_02.SetActive(false);
                Ajudante_04.SetActive(false);
                Ajudante_03.SetActive(false);
            } else if(Ajudante == 2)
            {
                Ajudante_02.SetActive(true);
                Ajudante_03.SetActive(false);
                Ajudante_04.SetActive(false);
                Ajudante_01.SetActive(false);
            } else if(Ajudante == 3)
            {
                Ajudante_03.SetActive(true);
                Ajudante_01.SetActive(false);
                Ajudante_02.SetActive(false);
                Ajudante_04.SetActive(false);
            } else if(Ajudante == 4)
            {
                Ajudante_04.SetActive(true);
                Ajudante_01.SetActive(false);
                Ajudante_02.SetActive(false);
                Ajudante_03.SetActive(false);
            }
        }

        NomeIncentivo.text = "Você consegue " + NomeJogador + "!"; 
    }
}
