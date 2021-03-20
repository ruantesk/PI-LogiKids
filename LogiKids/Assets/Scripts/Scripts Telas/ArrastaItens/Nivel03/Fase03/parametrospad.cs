using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parametrospad : MonoBehaviour
{
    public Transform place1;
    public Transform place2;
    public Transform place3;
    
    public GameObject erro;

    public string NomeObj = "";

    private Vector2 initialPosition;
    private float deltaX, deltaY;

    private float dif01x;
    private float dif02x;
    private float dif03x;
    
    private float dif01y;
    private float dif02y;
    private float dif03y;
    
    private bool locked;
    public static bool lockedDef;

    void Start()
    {
        initialPosition = transform.position;
        locked = true;
        lockedDef = true;

        Confirma03_03.parCOMER = "";
        Confirma03_03.parSAIR = "";
        Confirma03_03.parFAZER = "";
        
        Confirma03_03.Parametro01 = "";
        Confirma03_03.Parametro02 = "";
        Confirma03_03.Parametro03 = "";
    }

    private void Update()
    {
        Vector3 touchPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));


        if (Input.GetMouseButtonDown(0))
        {
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
            {
                locked = false;
                deltaX = touchPos.x - transform.position.x;
                deltaY = touchPos.y - transform.position.y;
            }
        }

        if (Input.GetMouseButton(0) && (locked == false))
        {
            if (Confirma03_03.Metodo01 != "" && Confirma03_03.Metodo02 != "" && Confirma03_03.Metodo03 != "")
            {
                lockedDef = false;
                metodospad.lockedDef = true;
                if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
            }
            else
            {
                erro.SetActive(true);
                lockedDef = true;
                Invoke("Limpaerro", 10);
            }
        }

        if ((Input.GetMouseButtonUp(0)) && (locked == false) && (lockedDef == false))
        {
            dif01x = Mathf.Abs(transform.position.x - place1.position.x);
            dif01y = Mathf.Abs(transform.position.y - place1.position.y);

            dif02x = Mathf.Abs(transform.position.x - place2.position.x);
            dif02y = Mathf.Abs(transform.position.y - place2.position.y);

            dif03x = Mathf.Abs(transform.position.x - place3.position.x);
            dif03y = Mathf.Abs(transform.position.y - place3.position.y);

            if ((dif01x <= 0.5f) && (dif01y <= 0.5f) && (Confirma03_03.Parametro01 == ""))
            {
                transform.position = new Vector2(place1.position.x, place1.position.y);
                locked = true;
                Confirma03_03.Parametro01 = NomeObj;

                if (Confirma03_03.Metodo01 == "COMER")
                {
                    Confirma03_03.parCOMER = NomeObj;
                }
                else if (Confirma03_03.Metodo01 == "FAZER")
                {
                    Confirma03_03.parFAZER = NomeObj;
                }
                else if (Confirma03_03.Metodo01 == "SAIR")
                {
                    Confirma03_03.parSAIR = NomeObj;
                }
            }
            else if ((dif02x <= 0.5f) && (dif02y <= 0.5f) && (Confirma03_03.Parametro02 == ""))
            {
                transform.position = new Vector2(place2.position.x, place2.position.y);
                locked = true;
                Confirma03_03.Parametro02 = NomeObj;

                if (Confirma03_03.Metodo02 == "COMER")
                {
                    Confirma03_03.parCOMER = NomeObj;
                }
                else if (Confirma03_03.Metodo02 == "FAZER")
                {
                    Confirma03_03.parFAZER = NomeObj;
                }
                else if (Confirma03_03.Metodo02 == "SAIR")
                {
                    Confirma03_03.parSAIR = NomeObj;
                }
            }
            else if ((dif03x <= 0.5f) && (dif03y <= 0.5f) && (Confirma03_03.Parametro03 == ""))
            {
                transform.position = new Vector2(place3.position.x, place3.position.y);
                locked = true;
                Confirma03_03.Parametro03 = NomeObj;

                if (Confirma03_03.Metodo03 == "COMER")
                {
                    Confirma03_03.parCOMER = NomeObj;
                }
                else if (Confirma03_03.Metodo03 == "FAZER")
                {
                    Confirma03_03.parFAZER = NomeObj;
                }
                else if (Confirma03_03.Metodo03 == "SAIR")
                {
                    Confirma03_03.parSAIR = NomeObj;
                }
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);

                if (Confirma03_03.Parametro01 == NomeObj)
                {
                    Confirma03_03.Parametro01 = "";
                }
                else if (Confirma03_03.Parametro02 == NomeObj)
                {
                    Confirma03_03.Parametro02 = "";
                }
                else if (Confirma03_03.Parametro03 == NomeObj)
                {
                    Confirma03_03.Parametro03 = "";
                }
            }
        }
    }

    void Limpaerro()
    {
        erro.SetActive(false);
    }
}
