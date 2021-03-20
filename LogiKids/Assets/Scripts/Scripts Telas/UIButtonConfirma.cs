using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonConfirma : MonoBehaviour
{
    public static bool SaiuDaFase01_01 = false;
    public static bool SaiuDaFase01_02 = false;
    public static bool SaiuDaFase01_03 = false;

    public static bool SaiuDaFase02_01 = false;
    public static bool SaiuDaFase02_02 = false;
    public static bool SaiuDaFase02_03 = false;

    public static bool SaiuDaFase03_01 = false;
    public static bool SaiuDaFase03_02 = false;
    public static bool SaiuDaFase03_03 = false;

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
        if(Textos.NivelAtual == "01")
        {
            if(Textos.FaseAtual == "01")
            {
                SaiuDaFase01_01 = true;
            } else if(Textos.FaseAtual == "02")
            {
                SaiuDaFase01_02 = true;
            } else if(Textos.FaseAtual == "03")
            {
                SaiuDaFase01_03 = true;
            }
        } else if(Textos.NivelAtual == "02")
        {
            if (Textos.FaseAtual == "01")
            {
                SaiuDaFase02_01 = true;
            }
            else if (Textos.FaseAtual == "02")
            {
                SaiuDaFase02_02 = true;
            }
            else if (Textos.FaseAtual == "03")
            {
                SaiuDaFase02_03 = true;
            }
        } else if(Textos.NivelAtual == "03")
        {
            if (Textos.FaseAtual == "01")
            {
                SaiuDaFase03_01 = true;
            }
            else if (Textos.FaseAtual == "02")
            {
                SaiuDaFase03_02 = true;
            }
            else if (Textos.FaseAtual == "03")
            {
                SaiuDaFase03_03 = true;
            }
        }

        Câmera.TagTela = "TelaMenu";
        gameObject.GetComponentsInParent<Transform>()[1].gameObject.SetActive(false);
        Fundos.PlayOneShot(AbreTela);
    }
}
