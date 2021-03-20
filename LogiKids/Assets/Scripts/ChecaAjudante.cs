using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//using System;
using TMPro;


public class ChecaAjudante : MonoBehaviour
{
    public int NumAjudante;

    public TMP_Text Aviso;

    public AudioClip SomTigre;
    public AudioClip SomRato;
    public AudioClip SomOvelha;
    public AudioClip SomCachorro;

    void OnMouseDown()
    {
        //ArmazenaInfo_Login.Ajudante = NumAjudante;

        ArmazenaInfo_Login.Ajudante = NumAjudante;
        Debug.Log(ArmazenaInfo_Login.Ajudante);
        PlayerPrefs.SetInt("ajudante", NumAjudante);
        
        switch (NumAjudante)
        {
            case 1:
                Aviso.text = "Você escolheu o ajudante tigre!";
                AudioSource.PlayClipAtPoint(SomTigre, transform.position);
                break;
            case 2:
                Aviso.text = "Você escolheu o ajudante rato!";
                AudioSource.PlayClipAtPoint(SomRato, transform.position);
                break;
            case 3:
                Aviso.text = "Você escolheu o ajudante ovelha!";
                AudioSource.PlayClipAtPoint(SomOvelha, transform.position);
                break;
            case 4:
                Aviso.text = "Você escolheu o ajudante cachorro!";
                AudioSource.PlayClipAtPoint(SomCachorro, transform.position);
                break;
        }

        Invoke("LimpaAviso", 5);
    }

    void LimpaAviso()
    {
        Aviso.text = ""; 
    }

 }
