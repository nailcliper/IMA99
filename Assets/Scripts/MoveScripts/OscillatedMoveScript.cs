using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillatedMoveScript : MoveScript {
    /*
    float amplitude;
    float frequency;
    float angleX;
    float angleY;

    [System.Serializable]
    public struct MovePath
    {
        public float startWait;
        public float endWait;
        public Vector2 moveBy;
        public Vector2 moveTo;
        public float speed;
        public float time;
        public float amplitude;
        public float frequency;
    }

    public MovePath[] movePaths = new MovePath[1];

    protected override IEnumerator MoveObject()
    {
        yield return base.MoveObject();

        for (int i = 0; i < movePaths.Length; i++)
        {
            startPos = transform.position;
            amplitude = movePaths[i].amplitude;
            speed = movePaths[i].speed;
            frequency = movePaths[i].frequency;

            if (movePaths[i].moveBy == zeroVector)
                endPos = movePaths[i].moveTo;
            else
                CalcEndPos(movePaths[i].moveBy);

            if(movePaths[i].speed == 0)
            {
                speed = CalcSpeed(movePaths[i].time);
            }
            else
            {
                speed = movePaths[i].speed;
            }

            if (movePaths[i].startWait > 0)
                yield return new WaitForSeconds(movePaths[i].startWait);

            if (amplitude != 0 && frequency != 0)
            {

                Vector2 direction = startPos;
                Vector2 oscillation = startPos;
                CalcOsc();

                float t = 0;
                while (direction != endPos)
                {
                    t += Time.deltaTime;

                    direction = Vector2.MoveTowards(direction, endPos, speed * Time.deltaTime);

                    oscillation.x = amplitude * (Mathf.Sin(t * frequency * speed) * angleX);
                    oscillation.y = amplitude * (Mathf.Sin(t * frequency * speed) * angleY);

                    obj.transform.position = direction + oscillation;
                    yield return new WaitForFixedUpdate();
                }
                obj.transform.position = direction;


                /*
                float t = 0;
                float omega = speed * frequency;
                float vmax = amplitude * omega;
                while (direction != endPos)
                {
                    t += Time.deltaTime;

                    velocity = Mathf.Abs(amplitude * omega * Mathf.Cos((omega * t)));

                    direction = Vector2.MoveTowards(direction, endPos, speed * Time.deltaTime);

                    oscillation.x = amplitude * (Mathf.Sin(t * frequency * speed) * angleX);
                    oscillation.y = amplitude * (Mathf.Sin(t * frequency * speed) * angleY);

                    transform.position = direction + oscillation;
                    
                    yield return new WaitForFixedUpdate();
                }
                transform.position = direction;
                */

                /*
                find vmax
                find equation to change vmax to speed
                make s constant
                */

                /*
                float t = 0;
                float omega = speed * frequency;
                float vmax = amplitude * omega;
                float vs = vmax / speed;
                while (direction != endPos)
                {
                    t += Time.deltaTime;

                    velocity = Mathf.Abs(vmax * Mathf.Cos((omega * t)));
                    s = velocity / vs;

                    direction = Vector2.MoveTowards(direction, endPos, s * Time.deltaTime);

                    oscillation.x = amplitude * (Mathf.Sin(t * omega) * angleX);
                    oscillation.y = amplitude * (Mathf.Sin(t * omega) * angleY);

                    transform.position = direction + oscillation;

                    yield return new WaitForFixedUpdate();
                }
                transform.position = direction;
                */
                /*
            }
            else
            {
                while ((Vector2)obj.transform.position != endPos)
                {
                    obj.transform.position = Vector2.MoveTowards(obj.transform.position, endPos, speed * Time.deltaTime);
                    yield return new WaitForFixedUpdate();
                }
            }

            if (movePaths[i].endWait > 0)
                yield return new WaitForSeconds(movePaths[i].endWait);
        }

        if (patternScript)
        {
            patternScript.NextMove();
        }
    }

    void CalcOsc()
    {
        angleX = Mathf.Sin((Mathf.Atan2(endPos.y - startPos.y, endPos.x - startPos.x)));
        angleY = -Mathf.Cos((Mathf.Atan2(endPos.y - startPos.y, endPos.x - startPos.x)));
        frequency = frequency * ((2 * Mathf.PI) / Mathf.Abs(Vector2.Distance(startPos, endPos)));
    }
    */
}
