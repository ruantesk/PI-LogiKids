using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Confirma03_01 : MonoBehaviour
{
    public GameObject obj01;
    public GameObject obj02;
    public GameObject obj03;
    public GameObject obj04;
    public GameObject obj05;

    public GameObject Alerta;
    public GameObject BotãoConfirma;

    private Vector2 obj01Inicial;
    private Vector2 obj02Inicial;
    private Vector2 obj03Inicial;
    private Vector2 obj04Inicial;
    private Vector2 obj05Inicial;

    public static string Ocupa01;
    public static string Ocupa02;
    public static string Ocupa03;
    public static string Ocupa04;
    public static string Ocupa05;

    void Start()
    {
        obj01Inicial = obj01.gameObject.transform.position;
        obj02Inicial = obj02.gameObject.transform.position;
        obj03Inicial = obj03.gameObject.transform.position;
        obj04Inicial = obj04.gameObject.transform.position;
        obj05Inicial = obj05.gameObject.transform.position;
    }

    void OnMouseDown()
    {
        if ((Ocupa01 != "") || (Ocupa02 != "") || (Ocupa03 != "") || (Ocupa04 != "") || (Ocupa05 != ""))
        {
            Textos.NivelAtual = "03";
            Textos.FaseAtual = "02";
            Câmera.TagTela = "Help03-02";

            obj01.gameObject.transform.position = new Vector2(obj01Inicial.x, obj01Inicial.y);
            obj02.gameObject.transform.position = new Vector2(obj02Inicial.x, obj02Inicial.y);
            obj03.gameObject.transform.position = new Vector2(obj03Inicial.x, obj03Inicial.y);
            obj04.gameObject.transform.position = new Vector2(obj04Inicial.x, obj04Inicial.y);
            obj05.gameObject.transform.position = new Vector2(obj05Inicial.x, obj05Inicial.y);
        }
        else
        {
            Alerta.SetActive(true);
            BotãoConfirma.SetActive(true);
        }
    }

    void Update()
    {
        if (UIButtonConfirma.SaiuDaFase03_01 == true)
        {
            obj01.gameObject.transform.position = new Vector2(obj01Inicial.x, obj01Inicial.y);
            obj02.gameObject.transform.position = new Vector2(obj02Inicial.x, obj02Inicial.y);
            obj03.gameObject.transform.position = new Vector2(obj03Inicial.x, obj03Inicial.y);
            obj04.gameObject.transform.position = new Vector2(obj04Inicial.x, obj04Inicial.y);
            obj05.gameObject.transform.position = new Vector2(obj05Inicial.x, obj05Inicial.y);
            UIButtonConfirma.SaiuDaFase03_01 = false;
        }
    }
}
