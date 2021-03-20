using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class Confirma03_03 : MonoBehaviour
{
    public GameObject met01;
    public GameObject met02;
    public GameObject met03;

    public GameObject Alerta;
    public GameObject BotãoConfirma;

    public GameObject par01;
    public GameObject par02;
    public GameObject par03;

    private Vector2 met01Ini;
    private Vector2 met02Ini;
    private Vector2 met03Ini;

    private Vector2 par01Ini;
    private Vector2 par02Ini;
    private Vector2 par03Ini;

    public static string Metodo01;
    public static string Metodo02;
    public static string Metodo03;

    public static string Parametro01;
    public static string Parametro02;
    public static string Parametro03;

    public static string parCOMER;
    public static string parFAZER;
    public static string parSAIR;

    void Start()
    {
        met01Ini = met01.gameObject.transform.position;
        met02Ini = met02.gameObject.transform.position;
        met03Ini = met03.gameObject.transform.position;
       
        par01Ini = par01.gameObject.transform.position;
        par02Ini = par02.gameObject.transform.position;
        par03Ini = par03.gameObject.transform.position;
    }

    void OnMouseDown()
    {
        if (Metodo01 == "COMER" && Metodo02 == "SAIR" && Metodo03 == "FAZER")
        {
            //Debug.Log("Entrouif01");
            if (parCOMER == "CEREAL" && parFAZER == "XIXI" && parSAIR == "ESCOLA")
            {
                Textos.NivelAtual = "01";
                Textos.FaseAtual = "01";
                Câmera.TagTela = "TelaMenu";

                met01.gameObject.transform.position = new Vector2(met01Ini.x, met01Ini.y);
                met02.gameObject.transform.position = new Vector2(met02Ini.x, met02Ini.y);
                met03.gameObject.transform.position = new Vector2(met03Ini.x, met03Ini.y);
                
                par01.gameObject.transform.position = new Vector2(par01Ini.x, par01Ini.y);
                par02.gameObject.transform.position = new Vector2(par02Ini.x, par02Ini.y);
                par03.gameObject.transform.position = new Vector2(par03Ini.x, par03Ini.y);
                
                metodospad.lockedDef = false;
                parametrospad.lockedDef = true;
            }
            else
            {
                Alerta.SetActive(true);
                BotãoConfirma.SetActive(true);

                Invoke("ZeraTudo", 1);
            }
        }
        else
        {
            Alerta.SetActive(true);
            BotãoConfirma.SetActive(true);

            Invoke("ZeraTudo", 1);
        }
    }

    void Update()
    {
        if (UIButtonConfirma.SaiuDaFase03_03 == true)
        {
            Invoke("ZeraTudo", 1);

            UIButtonConfirma.SaiuDaFase03_03 = false;
        }
    }

    void ZeraTudo()
    {
        met01.gameObject.transform.position = new Vector2(met01Ini.x, met01Ini.y);
        met02.gameObject.transform.position = new Vector2(met02Ini.x, met02Ini.y);
        met03.gameObject.transform.position = new Vector2(met03Ini.x, met03Ini.y);

        par01.gameObject.transform.position = new Vector2(par01Ini.x, par01Ini.y);
        par02.gameObject.transform.position = new Vector2(par02Ini.x, par02Ini.y);
        par03.gameObject.transform.position = new Vector2(par03Ini.x, par03Ini.y);

        metodospad.lockedDef = false;
        parametrospad.lockedDef = true;

        Metodo01 = "";
        Metodo02 = "";
        Metodo03 = "";

        Parametro01 = "";
        Parametro02 = "";
        Parametro03 = "";

        parCOMER = "";
        parFAZER = "";
        parSAIR = "";
    }
}
