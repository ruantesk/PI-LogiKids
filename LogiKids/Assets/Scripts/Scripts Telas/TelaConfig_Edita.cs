using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;


public class TelaConfig_Edita : MonoBehaviour
{
    public GameObject textao;
    public bool IsEditaNome;
    public TMP_InputField Textinho;

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
        if(IsEditaNome)
        {
            textao.SetActive(true);
        } else
        {
            ArmazenaInfo_Login.NomeJogador = Textinho.GetComponent<TMP_InputField>().text;
            PlayerPrefs.SetString("nome", Textinho.GetComponent<TMP_InputField>().text);
            Debug.Log(ArmazenaInfo_Login.NomeJogador);
            Câmera.TagTela = "TelaMenu";
            Fundos.PlayOneShot(AbreTela);
        }
    }
}
