using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConfirmaAjudante : MonoBehaviour
{
    public TMP_Text Aviso;

    public AudioClip AbreTela;

    private AudioSource Fundos;
    private GameObject AudioSource;

    void Start()
    {
        AudioSource = GameObject.FindGameObjectWithTag("AudioSource");
        Fundos = AudioSource.GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        PlayerPrefs.SetInt("jogou", 1);

        if (ArmazenaInfo_Login.Ajudante != 0)
        {
            Câmera.TagTela = "TelaMenu";
            Fundos.PlayOneShot(AbreTela);
        } else
        {
            Aviso.text = "Selecione um ajudante!";
            Invoke("LimpaAviso", 5);
        }
    }

    void LimpaAviso()
    {
        Aviso.text = "";
    }
}
