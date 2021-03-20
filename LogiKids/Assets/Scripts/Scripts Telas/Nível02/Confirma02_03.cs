using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Confirma02_03 : MonoBehaviour
{
    public GameObject BOLA;
    public GameObject ROUPA;
    public GameObject SUCRILHOS;

    public GameObject Alerta;
    public GameObject BotãoConfirma;

    private Vector2 BOLAInicial;
    private Vector2 ROUPAInicial;
    private Vector2 SUCRILHOSInicial;

    public static string Posicao01;
    public static string Posicao02;
    public static string Posicao03;

    void Start()
    {
        ROUPAInicial = ROUPA.gameObject.transform.position;
        BOLAInicial = BOLA.gameObject.transform.position;
        SUCRILHOSInicial = SUCRILHOS.gameObject.transform.position;
    }

    void OnMouseDown()
    {
        if ((Posicao01 == "SUCRILHOS") && (Posicao02 == "BOLA") && (Posicao03 == "ROUPA"))
        {
            Textos.NivelAtual = "03";
            Textos.FaseAtual = "01";
            Câmera.TagTela = "Help03-01";
            ROUPA.gameObject.transform.position = new Vector2(ROUPAInicial.x, ROUPAInicial.y);
            SUCRILHOS.gameObject.transform.position = new Vector2(SUCRILHOSInicial.x, SUCRILHOSInicial.y);
            BOLA.gameObject.transform.position = new Vector2(BOLAInicial.x, BOLAInicial.y);
        }
        else
        {
            Alerta.SetActive(true);
            BotãoConfirma.SetActive(true);
        }
    }

    void Update()
    {
        if (UIButtonConfirma.SaiuDaFase02_03 == true)
        {
            ROUPA.gameObject.transform.position = new Vector2(ROUPAInicial.x, ROUPAInicial.y);
            SUCRILHOS.gameObject.transform.position = new Vector2(SUCRILHOSInicial.x, SUCRILHOSInicial.y);
            BOLA.gameObject.transform.position = new Vector2(BOLAInicial.x, BOLAInicial.y);
            UIButtonConfirma.SaiuDaFase02_03 = false;
        }
    }
}
