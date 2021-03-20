using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Confirma02_01 : MonoBehaviour
{
    public GameObject Escova;
    public GameObject Cereal;
    public GameObject Bola;

    public GameObject Alerta;
    public GameObject BotãoConfirma;

    private Vector2 EscovaInicial;
    private Vector2 BolaInicial;
    private Vector2 CerealInicial;

    public static string Posicao01;
    public static string Posicao02;
    public static string Posicao03;

    void Start()
    {
        EscovaInicial = Escova.gameObject.transform.position;
        BolaInicial = Bola.gameObject.transform.position;
        CerealInicial = Cereal.gameObject.transform.position;
    }

    void OnMouseDown()
    {

        if ((Posicao01 == "ESCOVA") && (Posicao02 == "CEREAL") && (Posicao03 == "BOLA"))
        {
            Textos.NivelAtual = "02";
            Textos.FaseAtual = "02";
            Câmera.TagTela = "Help02-02";
            Escova.gameObject.transform.position = new Vector2(EscovaInicial.x, EscovaInicial.y);
            Cereal.gameObject.transform.position = new Vector2(CerealInicial.x, CerealInicial.y);
            Bola.gameObject.transform.position = new Vector2(BolaInicial.x, BolaInicial.y);
        } else
        {
            Alerta.SetActive(true);
            BotãoConfirma.SetActive(true);
        }
            
    }

    void Update()
    {
        if (UIButtonConfirma.SaiuDaFase02_01 == true)
        {
            Escova.gameObject.transform.position = new Vector2(EscovaInicial.x, EscovaInicial.y);
            Cereal.gameObject.transform.position = new Vector2(CerealInicial.x, CerealInicial.y);
            Bola.gameObject.transform.position = new Vector2(BolaInicial.x, BolaInicial.y);
            UIButtonConfirma.SaiuDaFase02_01 = false;
        }
    }
}
