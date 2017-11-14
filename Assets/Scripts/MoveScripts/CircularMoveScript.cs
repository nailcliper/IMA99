using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMoveScript : MoveScript
{
    /*
    float startWait;
    float endWait;
    float startAngle;
    float curAngle;
    float endAngle;
    float radius;
    bool counterClockwise = false;
    //public float time;

    [System.Serializable]
    public struct MovePath
    {
        public float startWait;
        public float endWait;
        public float startAngle;
        public float endAngle;
        public float radius;
        public bool counterClockwise;
        public float speed;
        //public float time;
    }
    public MovePath[] movePaths = new MovePath[1];

    Vector2 CalcCircle()
    {
        float x = startPos.x - (radius * Mathf.Cos(Mathf.Deg2Rad * (startAngle + 90)));
        float y = startPos.y - (radius * Mathf.Sin(Mathf.Deg2Rad * (startAngle + 90)));

        return new Vector2(x, y);
    }

    float CalcSpeed() //fix?
    {
        float theta = 100; //seems to be equal to basic moving velocity
        float circumfernce = 2 * radius * Mathf.PI;
        float arc = ((theta * circumfernce) / 360);
        float chord = 2 * radius * Mathf.Sin(Mathf.Deg2Rad * (theta / 2));
        return speed * arc / chord;
    }

    float CalcArc(float angle)
    {
        float theta = angle;
        float circumference = 2 * radius * Mathf.PI;
        return ((theta * circumference)) / 360;
    }

    protected override IEnumerator MoveObject()
    {
        for (int i = 0; i < movePaths.Length; i++)
        {
            startPos = transform.position;

            startWait = movePaths[i].startWait;
            endWait = movePaths[i].endWait;
            startAngle = movePaths[i].startAngle;
            endAngle = movePaths[i].endAngle;
            radius = movePaths[i].radius;
            counterClockwise = movePaths[i].counterClockwise;
            speed = movePaths[i].speed;

            if(startWait > 0)
                yield return new WaitForSeconds(startWait);

            Vector2 centerPoint = CalcCircle();
            float t = -(startAngle * Mathf.Deg2Rad);
            float arc = CalcArc(endAngle);
            float a = arc;
            float s = CalcSpeed();

            while (a > 0)
            {
                if (counterClockwise)
                    t -= Time.deltaTime * s / radius;
                else
                    t += Time.deltaTime * s / radius;

                float x = radius * Mathf.Sin(t) + centerPoint.x;
                float y = radius * Mathf.Cos(t) + centerPoint.y;

                Vector2 newPos = new Vector2(x, y);
                a -= Vector2.Distance(transform.position, newPos);
                transform.position = newPos;

                yield return new WaitForEndOfFrame();
            }

            if (endWait > 0)
                yield return new WaitForSeconds(endWait);
        }

        if (patternScript)
        {
            patternScript.NextMove();
        }
    }
    */
}
