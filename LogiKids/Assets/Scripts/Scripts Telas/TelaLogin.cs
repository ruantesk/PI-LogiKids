using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class TelaLogin : MonoBehaviour
{
    public TMP_InputField Textinho;
    public TMP_Text TextoErro;

    public AudioClip AbreTela;

    private AudioSource Fundos;
    private GameObject AudioSource;

    void Start()
    {
        AudioSource = GameObject.FindGameObjectWithTag("AudioSource");
        Fundos = AudioSource.GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if(Textinho)
        {
            if(Textinho.text == "Insira seu nome")
            {
                TextoErro.text = "Insira um nome!";
                Invoke("LimpaAviso", 5);
            } else
            {
                Fundos.PlayOneShot(AbreTela);
                ArmazenaInfo_Login.NomeJogador = Textinho.GetComponent<TMP_InputField>().text;
                Debug.Log(ArmazenaInfo_Login.NomeJogador);
                Câmera.TagTela = "TelaAjudante";
                PlayerPrefs.SetString("nome", Textinho.text);
            }
        }   
    }

    void LimpaAviso()
    {
        TextoErro.text = "";
    }
}
