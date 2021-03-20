using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Confirma01_02 : MonoBehaviour
{
    public static bool InseriuAlgumaCoisa;

    public GameObject Camisa;
    public GameObject Cereal;
    public GameObject Escova;
    public GameObject Vaso;
    public GameObject Alerta;
    public GameObject BotãoConfirma;

    private Vector2 CamisaInicial;
    private Vector2 CerealInicial;
    private Vector2 EscovaInicial;
    private Vector2 VasoInicial;

    public static string Posicao01;
    public static string Posicao02;
    public static string Posicao03;
    public static string Posicao04;

    void Start()
    {
        CamisaInicial = Camisa.gameObject.transform.position;
        CerealInicial = Cereal.gameObject.transform.position;
        EscovaInicial = Escova.gameObject.transform.position;
        VasoInicial = Vaso.gameObject.transform.position;
    }

    void OnMouseDown()
    {
        if(Posicao01 != "" || Posicao02 != "" || Posicao03 != "" || Posicao04 != "")
        {
            Textos.NivelAtual = "01";
            Textos.FaseAtual = "03";
            Câmera.TagTela = "Help01-03";
            Camisa.gameObject.transform.position = new Vector2(CamisaInicial.x, CamisaInicial.y);
            Cereal.gameObject.transform.position = new Vector2(CerealInicial.x, CerealInicial.y);
            Escova.gameObject.transform.position = new Vector2(EscovaInicial.x, EscovaInicial.y);
            Vaso.gameObject.transform.position   = new Vector2(VasoInicial.x, VasoInicial.y);

        }
        else
        {
            Alerta.SetActive(true);
            BotãoConfirma.SetActive(true);
        }
        
    }

    void Update()
    {
        if (UIButtonConfirma.SaiuDaFase01_02 == true)
        {
            Camisa.gameObject.transform.position = new Vector2(CamisaInicial.x, CamisaInicial.y);
            Cereal.gameObject.transform.position = new Vector2(CerealInicial.x, CerealInicial.y);
            Escova.gameObject.transform.position = new Vector2(EscovaInicial.x, EscovaInicial.y);
            Vaso.gameObject.transform.position   = new Vector2(VasoInicial.x, VasoInicial.y);
            UIButtonConfirma.SaiuDaFase01_02 = false;
        }
    }
}
