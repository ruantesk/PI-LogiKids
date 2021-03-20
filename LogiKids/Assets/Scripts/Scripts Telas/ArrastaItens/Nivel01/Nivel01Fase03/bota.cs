using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bota : MonoBehaviour
{
    //[SerializeField]
    public Transform place1;
    //[SerializeField]
    public Transform place2;

    private Vector2 initialPosition;
    private float deltaX, deltaY;

    private float dif01x;
    private float dif02x;

    private float dif01y;
    private float dif02y;

    private bool locked;

    void Start()
    {
        initialPosition = transform.position;
        locked = true;
        Confirma01_03.Posicao01 = "";
        Confirma01_03.Posicao02 = "";
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

            if (dif01x <= 0.5f && dif01y <= 0.5f && Confirma01_03.Posicao01 == "")
            {
                transform.position = new Vector2(place1.position.x, place1.position.y);
                locked = true;
                Confirma01_03.Posicao01 = "Bota";
            }
            else if (dif02x <= 0.5f && dif02y <= 0.5f && Confirma01_03.Posicao02 == "")
            {
                transform.position = new Vector2(place2.position.x, place2.position.y);
                locked = true;
                Confirma01_03.Posicao02 = "Bota";
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
                if (Confirma01_03.Posicao01 == "Bota")
                {
                    Confirma01_03.Posicao01 = "";
                }
                else if (Confirma01_03.Posicao02 == "Bota")
                {
                    Confirma01_03.Posicao02 = "";
                }
            }
        }
    }
}
