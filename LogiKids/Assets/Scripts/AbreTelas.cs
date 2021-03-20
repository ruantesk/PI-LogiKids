using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;


public class AbreTelas : MonoBehaviour
{
    public string TagPróximaTela;

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
        Fundos.PlayOneShot(AbreTela);
        Câmera.TagTela = TagPróximaTela;
    }
}
