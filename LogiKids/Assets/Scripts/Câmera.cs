using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Câmera : MonoBehaviour
{
    public static string TagTela = "TelaInicio";

    public AudioClip TelaInfoSom;
    public AudioClip TelaHelpSom;

    private float xMax = 150;
    private float xMin = -150;
    private float yMax = 150;
    private float yMin = -150;
    private GameObject tela;

    private string UltimaTag = "";

    private AudioSource Fundos;
    private GameObject AudioSource;
    void Start()
    {
        if (PlayerPrefs.GetInt("jogou", 0) != 0)
        {
            ArmazenaInfo_Login.NomeJogador = PlayerPrefs.GetString("nome", "no name");
            ArmazenaInfo_Login.Ajudante    = PlayerPrefs.GetInt("ajudante", 0);
            Textos.NivelAtual  = PlayerPrefs.GetInt("nivel", 0).ToString();
            Textos.FaseAtual   = PlayerPrefs.GetInt("fase", 0).ToString();
        } 

        AudioSource = GameObject.FindGameObjectWithTag("AudioSource");
        Fundos = AudioSource.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (TagTela != UltimaTag)
        {
            if (TagTela.Substring(0, 4) == "Help")
            {
                Fundos.PlayOneShot(TelaHelpSom);
                
            } else if(TagTela.Substring(0, 4) == "Info")
            {
                Fundos.PlayOneShot(TelaInfoSom);
            }

            Debug.Log(TagTela.Substring(0, 4));

            tela = GameObject.FindGameObjectWithTag(TagTela);

            float x = Mathf.Clamp(tela.transform.position.x, xMin, xMax);
            float y = Mathf.Clamp(tela.transform.position.y, yMin, yMax);
            gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);

            PlayerPrefs.SetInt("nivel", Int32.Parse(Textos.NivelAtual));
            PlayerPrefs.SetInt("fase", Int32.Parse(Textos.FaseAtual));

            UltimaTag = TagTela;
        }
        
    }
}
