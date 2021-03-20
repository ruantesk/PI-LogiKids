using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Confirma01_03 : MonoBehaviour
{
    public GameObject Chinelo;
    public GameObject Bota;
    public GameObject Sapato;

    public GameObject Alerta;
    public GameObject BotãoConfirma;

    private Vector2 ChineloInicial;
    private Vector2 BotaInicial;
    private Vector2 SapatoInicial;

    public static string Posicao01;
    public static string Posicao02;

    void Start()
    {
        ChineloInicial = Chinelo.gameObject.transform.position;
        BotaInicial = Bota.gameObject.transform.position;
        SapatoInicial = Sapato.gameObject.transform.position;
    }

    void OnMouseDown()
    {
        if ((Posicao01 == "SAPATO") || (Posicao01 == "BOTA"))
        {
            Textos.NivelAtual = "02";
            Textos.FaseAtual = "01";
            Câmera.TagTela = "Help02-01";
            Chinelo.gameObject.transform.position = new Vector2(ChineloInicial.x, ChineloInicial.y);
            Bota.gameObject.transform.position = new Vector2(BotaInicial.x, BotaInicial.y);
            Sapato.gameObject.transform.position = new Vector2(SapatoInicial.x, SapatoInicial.y);
        } else
        {
            Alerta.SetActive(true);
            BotãoConfirma.SetActive(true);
        }
    }

    void Update()
    {
        if (UIButtonConfirma.SaiuDaFase01_03 == true)
        {
            Chinelo.gameObject.transform.position = new Vector2(ChineloInicial.x, ChineloInicial.y);
            Bota.gameObject.transform.position = new Vector2(BotaInicial.x, BotaInicial.y);
            Sapato.gameObject.transform.position = new Vector2(SapatoInicial.x, SapatoInicial.y);
            UIButtonConfirma.SaiuDaFase01_03 = false;
        }
    }
}
