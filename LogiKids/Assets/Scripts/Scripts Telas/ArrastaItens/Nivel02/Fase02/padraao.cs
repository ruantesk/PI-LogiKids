using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padraao : MonoBehaviour
{
    public Transform place1;
    public Transform place2;
    public Transform place3;

    public string NomeObj;

    private Vector2 initialPosition;
    private float deltaX, deltaY;

    private float dif01x;
    private float dif02x;
    private float dif03x;

    private float dif01y;
    private float dif02y;
    private float dif03y;

    private bool locked;

    void Start()
    {
        initialPosition = transform.position;
        locked = true;
        Confirma02_02.Posicao01 = "";
        Confirma02_02.Posicao02 = "";
        Confirma02_02.Posicao03 = "";
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
            if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);
        }

        if ((Input.GetMouseButtonUp(0)) && (locked == false))
        {
            dif01x = Mathf.Abs(transform.position.x - place1.position.x);
            dif01y = Mathf.Abs(transform.position.y - place1.position.y);

            dif02x = Mathf.Abs(transform.position.x - place2.position.x);
            dif02y = Mathf.Abs(transform.position.y - place2.position.y);

            dif03x = Mathf.Abs(transform.position.x - place3.position.x);
            dif03y = Mathf.Abs(transform.position.y - place3.position.y);

            if (dif01x <= 0.8f && dif01y <= 0.8f && Confirma02_02.Posicao01 == "")
            {
                transform.position = new Vector2(place1.position.x, place1.position.y);
                locked = true;
                Confirma02_02.Posicao01 = NomeObj;
            }
            else if (dif02x <= 0.8f && dif02y <= 0.8f && Confirma02_02.Posicao02 == "")
            {
                transform.position = new Vector2(place2.position.x, place2.position.y);
                locked = true;
                Confirma02_02.Posicao02 = NomeObj;
            }
            else if (dif03x <= 0.8f && dif03y <= 0.8f && Confirma02_02.Posicao03 == "")
            {
                transform.position = new Vector2(place3.position.x, place3.position.y);
                locked = true;
                Confirma02_02.Posicao03 = NomeObj;
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                locked = true;
                if (Confirma02_02.Posicao01 == NomeObj)
                {
                    Confirma02_02.Posicao01 = "";
                }
                else if (Confirma02_02.Posicao02 == NomeObj)
                {
                    Confirma02_02.Posicao02 = "";
                }
                else if (Confirma02_02.Posicao03 == NomeObj)
                {
                    Confirma02_02.Posicao03 = "";
                }
            }
        }
    }
}
