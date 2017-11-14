using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMoveScript : MoveScript {
    /*
    [System.Serializable]
    public struct MovePath
    {
        public float startWait;
        public float endWait;
        public Vector2 moveBy;
        public Vector2 moveTo;
        public float speed;
        public float time;
        public bool easeInOut;
    }
    public MovePath[] movePaths = new MovePath[1];

    protected override IEnumerator MoveObject()
    {
        yield return base.MoveObject();

        for (int i = 0; i < movePaths.Length; i++)
        {
            startPos = obj.transform.position;

            if (movePaths[i].moveBy == zeroVector)
                endPos = movePaths[i].moveTo;
            else
                CalcEndPos(movePaths[i].moveBy);

            if (movePaths[i].startWait > 0)
                yield return new WaitForSeconds(movePaths[i].startWait);

            if (movePaths[i].speed == 0)
            {
                time = movePaths[i].time;
                speed = CalcSpeed(movePaths[i].time);
            }
            else
            {
                time = CalcTime(movePaths[i].speed);
                speed = movePaths[i].speed;
            }

            float t = 0;
            while ((Vector2)obj.transform.position != endPos)
            {
                if (movePaths[i].easeInOut)
                {
                    t += Time.deltaTime;
                    float x = AnimationCurve.EaseInOut(0, startPos.x, time, endPos.x).Evaluate(t);
                    float y = AnimationCurve.EaseInOut(0, startPos.y, time, endPos.y).Evaluate(t);
                    obj.transform.position = new Vector2(x, y);
                }
                else
                    obj.transform.position = Vector2.MoveTowards(obj.transform.position, endPos, speed * Time.deltaTime);
                yield return new WaitForFixedUpdate();
            }

            if (movePaths[i].endWait > 0)
                yield return new WaitForSeconds(movePaths[i].endWait);
                
        }

        if(patternScript)
        {
            patternScript.NextMove();
        }
    }
    */
}
