using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour {
    public bool test = false;
    protected Vector2 startPos;
    protected Vector2 curPos;
    protected Vector2 endPos;
    protected Vector2 zeroVector = new Vector2 (0,0);
    protected GameObject obj;
    public float speed;
    protected float time;
    protected PatternScript patternScript;
    Coroutine move;

    void Awake()
    {
        if (obj == null)
            obj = gameObject;
    }

    public void SetPatternScript(PatternScript script)
    {
        patternScript = script;
    }

    public void StartMove()
    {
        move = StartCoroutine(MoveObject());
    }

    public void StopMove()
    {
        StopCoroutine(move);
    }

    protected virtual IEnumerator MoveObject()
    {
        //startPos = obj.transform.position;
        //curPos = obj.transform.position;
        yield return null;
    }

    protected void CalcEndPos(Vector2 imove)
    {
        endPos = obj.transform.position;
        endPos += imove;
    }

    protected float CalcSpeed(float itime)
    {
        float distance = Vector2.Distance(startPos, endPos);
        return distance / itime;
    }

    protected float CalcTime(float ispeed)
    {
        float distance = Vector2.Distance(startPos, endPos);
        return distance / ispeed;
    }

    public void SetObject(GameObject iobj)
    {
        obj = iobj;
    }

    void OnDisable()
    {
        StopAllCoroutines();
    }

}
