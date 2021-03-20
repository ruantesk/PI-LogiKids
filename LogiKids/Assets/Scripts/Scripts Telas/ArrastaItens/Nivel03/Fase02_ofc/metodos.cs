﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metodos : MonoBehaviour
{
    public Transform place1;
    public Transform place2;
    public Transform place3;
    public Transform place4;

    public string NomeObj = "";

    private Vector2 initialPosition;
    private float deltaX, deltaY;

    private float dif01x;
    private float dif02x;
    private float dif03x;
    private float dif04x;

    private float dif01y;
    private float dif02y;
    private float dif03y;
    private float dif04y;

    private bool locked;
    public static bool lockedDef;

    void Start()
    {
        initialPosition = transform.position;
        locked = true;
        lockedDef = false;

        Confirma03_02.Metodo01 = "";
        Confirma03_02.Metodo02 = "";
        Confirma03_02.Metodo03 = "";
        Confirma03_02.Metodo04 = "";
    }

    private void Update()
    {
        Vector3 touchPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));

        if (Input.GetMouseButtonDown(0))
        {
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) && lockedDef == false)
            {
                locked = false;
                deltaX = touchPos.x - transform.position.x;
                deltaY = touchPos.y - transform.position.y;
            }
        }

        if (Input.GetMouseButton(0) && (locked == false) && lockedDef == false)
        {
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
        }

        if ((Input.GetMouseButtonUp(0)) && (locked == false) && lockedDef == false)
        {
            dif01x = Mathf.Abs(transform.position.x - place1.position.x);
            dif01y = Mathf.Abs(transform.position.y - place1.position.y);

            dif02x = Mathf.Abs(transform.position.x - place2.position.x);
            dif02y = Mathf.Abs(transform.position.y - place2.position.y);

            dif03x = Mathf.Abs(transform.position.x - place3.position.x);
            dif03y = Mathf.Abs(transform.position.y - place3.position.y);

            dif04x = Mathf.Abs(transform.position.x - place4.position.x);
            dif04y = Mathf.Abs(transform.position.y - place4.position.y);

            if ((dif01x <= 0.5f) && (dif01y <= 0.5f) && (Confirma03_02.Metodo01 == ""))
            {
                transform.position = new Vector2(place1.position.x, place1.position.y);
                locked = true;
                Confirma03_02.Metodo01 = NomeObj;
            }
            else if ((dif02x <= 0.5f) && (dif02y <= 0.5f) && (Confirma03_02.Metodo02 == ""))
            {
                transform.position = new Vector2(place2.position.x, place2.position.y);
                locked = true;
                Confirma03_02.Metodo02 = NomeObj;
            }
            else if ((dif03x <= 0.5f) && (dif03y <= 0.5f) && (Confirma03_02.Metodo03 == ""))
            {
                transform.position = new Vector2(place3.position.x, place3.position.y);
                locked = true;
                Confirma03_02.Metodo03 = NomeObj;
            }
            else if ((dif04x <= 0.5f) && (dif04y <= 0.5f) && (Confirma03_02.Metodo04 == ""))
            {
                transform.position = new Vector2(place4.position.x, place4.position.y);
                locked = true;
                Confirma03_02.Metodo04 = NomeObj;
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);

                if (Confirma03_02.Metodo01 == NomeObj)
                {
                    Confirma03_02.Metodo01 = "";
                }
                else if (Confirma03_02.Metodo02 == NomeObj)
                {
                    Confirma03_02.Metodo02 = "";
                }
                else if (Confirma03_02.Metodo03 == NomeObj)
                {
                    Confirma03_02.Metodo03 = "";
                }
                else if (Confirma03_02.Metodo04 == NomeObj)
                {
                    Confirma03_02.Metodo04 = "";
                }
            }
        }

    }
}


