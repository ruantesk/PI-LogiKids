using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Confirma02_02 : MonoBehaviour
{
    public GameObject JOGAR;
    public GameObject ESCOVAR;
    public GameObject COMER;

    public GameObject Alerta;
    public GameObject BotãoConfirma;

    private Vector2 JOGARInicial;
    private Vector2 ESCOVARInicial;
    private Vector2 COMERInicial;

    public static string Posicao01;
    public static string Posicao02;
    public static string Posicao03;

    void Start()
    {
        ESCOVARInicial = ESCOVAR.gameObject.transform.position;
        JOGARInicial = JOGAR.gameObject.transform.position;
        COMERInicial = COMER.gameObject.transform.position;
    }

    void OnMouseDown()
    {
        if ((Posicao01 == "ESCOVAR") && (Posicao02 == "COMER") && (Posicao03 == "JOGAR"))
        {
            Textos.NivelAtual = "02";
            Textos.FaseAtual = "03";
            Câmera.TagTela = "Help02-03";
            ESCOVAR.gameObject.transform.position = new Vector2(ESCOVARInicial.x, ESCOVARInicial.y);
            COMER.gameObject.transform.position = new Vector2(COMERInicial.x, COMERInicial.y);
            JOGAR.gameObject.transform.position = new Vector2(JOGARInicial.x, JOGARInicial.y);
        } else
        {
            Alerta.SetActive(true);
            BotãoConfirma.SetActive(true);
        }
    }

    void Update()
    {
        if (UIButtonConfirma.SaiuDaFase02_02 == true)
        {
            ESCOVAR.gameObject.transform.position = new Vector2(ESCOVARInicial.x, ESCOVARInicial.y);
            COMER.gameObject.transform.position = new Vector2(COMERInicial.x, COMERInicial.y);
            JOGAR.gameObject.transform.position = new Vector2(JOGARInicial.x, JOGARInicial.y);
            UIButtonConfirma.SaiuDaFase02_02 = false;
        }
    }
}
