using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoveScript : MoveScript {
    /*
    //Add move by speed

    public float startWait;
    public float endWait;
    public float rSpeed;
    public float rTime;
    public float interval;
    public int moves = 0;
    public bool easeInOut;
    public bool repeating = false;
    public bool local = false;
    public Vector2 bottomLeftBound;
    public Vector2 upperRightBound;
    public Vector2 minMove;
    public Vector2 maxMove;

    float minY;
    float maxY;
    float minX;
    float maxX;

    void Start()
    {
        speed = rSpeed;
        time = rTime;

        minY = bottomLeftBound.y;
        maxY = upperRightBound.y;
        minX = bottomLeftBound.x;
        maxX = upperRightBound.x;
    }

    protected override IEnumerator MoveObject()
    {
        yield return base.MoveObject();
        startPos = obj.transform.position;
        if (local)
        {
            minY += startPos.y;
            maxY += startPos.y;
            minX += startPos.x;
            maxX += startPos.x;
        }

        if (startWait > 0)
            yield return new WaitForSeconds(startWait);

        int imoves = moves;
        while (imoves > 0 || repeating == true)
        {
            startPos = obj.transform.position;
            endPos = GetRandomVector();

            if (time > 0)
                speed = CalcSpeed(time);
            else if (speed > 0)
                time = CalcTime(speed);

            float t = 0;
            while ((Vector2)obj.transform.position != endPos)
            {
                if (easeInOut)
                {
                    t += Time.deltaTime;
                    float x = AnimationCurve.EaseInOut(0, startPos.x, time, endPos.x).Evaluate(t);
                    float y = AnimationCurve.EaseInOut(0, startPos.y, time, endPos.y).Evaluate(t);
                    obj.transform.position = new Vector2(x, y);
                }
                else
                {
                    obj.transform.position = Vector2.MoveTowards(obj.transform.position, endPos, speed * Time.deltaTime);
                }
                yield return new WaitForFixedUpdate();
            }
            imoves--;
            yield return new WaitForSeconds(interval - (Time.deltaTime / time));
        }

        if (endWait > 0)
            yield return new WaitForSeconds(endWait);

        if (patternScript)
        {
            patternScript.NextMove();
        }
    }

    Vector2 GetRandomVector()
    {
        float mix = Mathf.Max(startPos.x - maxMove.x, minX);
        float miy = Mathf.Max(startPos.y - maxMove.y, minY);
        float max = Mathf.Min(startPos.x + maxMove.x, maxX);
        float may = Mathf.Min(startPos.y + maxMove.y, maxY);

        float mixi = Mathf.Max(startPos.x - minMove.x, minX);
        float miyi = Mathf.Max(startPos.y - minMove.y, minY);
        float maxi = Mathf.Min(startPos.x + minMove.x, maxX);
        float mayi = Mathf.Min(startPos.y + minMove.y, maxY);

        
        float x = Random.Range(maxi, max + Mathf.Abs(mix - mixi));
        if (x > max)
        {
            x -= max;
            x += mix;
        }

        float y = Random.Range(mayi, may + Mathf.Abs(miy - miyi));
        if (y > may)
        {
            y -= may;
            y += miy;
        }

        return new Vector2(x, y);
    }
    */
}
