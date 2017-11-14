using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMoveScript : MonoBehaviour {
    /*
    Vector2 startPos;
    Vector2 curPos;
    Vector2 endPos;
    public Vector2 direction;
    public float speed;
    public float amplitude;
    public float frequency;
    float a;
    float f;
    float angleX;
    float angleY;

    public Vector2 unfocusPos;
    public Vector2 focusPos;
    bool isFocused = false;
    PlayerManagerScript playerManager;


    void Awake()
    {
        startPos = unfocusPos;
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManagerScript>();
    }

    void OnEnable()
    {
        transform.localPosition = unfocusPos;
        startPos = unfocusPos;
        endPos = focusPos;
        direction = unfocusPos;
        a = amplitude;
        isFocused = false;
    }

    void OnDisable()
    {
        StopCoroutine(MoveObject());
    }

    void Update()
    {
        if (isFocused != playerManager.IsFocused())
            FlipFocus();
    }

    void FlipFocus()
    {
        StopCoroutine(MoveObject());
        isFocused = !isFocused;
        a = -a;
        if(isFocused)
        {
            startPos = unfocusPos;
            endPos = focusPos;
        }
        else
        {
            startPos = focusPos;
            endPos = unfocusPos;
        }
        StartCoroutine(MoveObject());
    }

    void CalcOsc()
    {
        angleX = Mathf.Sin((Mathf.Atan2(endPos.y - startPos.y, endPos.x - startPos.x)));
        angleY = -Mathf.Cos((Mathf.Atan2(endPos.y - startPos.y, endPos.x - startPos.x)));
        f = frequency * ((2 * Mathf.PI) / Mathf.Abs(Vector2.Distance(startPos, endPos)));
    }

    IEnumerator MoveObject()
    {
        if (amplitude != 0 && frequency != 0)
        {
            Vector2 oscillation = startPos;
            CalcOsc();

            float t = 0;
            while (direction != endPos)
            {
                direction = Vector2.MoveTowards(direction, endPos, speed * Time.deltaTime);

                oscillation.x = a * (Mathf.Sin(t * f * speed) * angleX);
                oscillation.y = a * (Mathf.Sin(t * f * speed) * angleY);

                transform.localPosition = direction + oscillation;
                t += Time.deltaTime;
                yield return new WaitForFixedUpdate();
            }

        }
        else
        {
            while ((Vector2)transform.position != endPos)
            {

                transform.position = Vector2.MoveTowards(transform.position, endPos, speed * Time.deltaTime);
                yield return new WaitForFixedUpdate();
            }
        }
        transform.localPosition = direction;
    }
    */
}
