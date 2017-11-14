using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternScript : MonoBehaviour {
    /*
    [System.Serializable]
    public class Pattern
    {
        public bool loop = true;
        public bool spellcard = false;
        public MoveScript[] moveScript;
        public FireScript[] fireScript;
    }
    public Pattern[] pattern;

    /*
    [System.Serializable]
    public class MoveScripts
    {
        public List<MoveScript> mScript;
    }

    [System.Serializable]
    public class BulletFireScripts
    {
        public BulletFireScript[] bulletFireScript;
    }

    [System.Serializable]
    public class FireScripts
    {
        public FireScript[] fireScript;
    }
    */
    /*
    int patternIndex;
    int moveIndex;
    MoveScript curMoveScript;
    BackgroundManagerScript backgroundManager;

    void Awake()
    {
        backgroundManager = GameObject.FindGameObjectWithTag("BackgroundManager").GetComponent<BackgroundManagerScript>();
        patternIndex = 0;
        moveIndex = 0;
        for (int i = 0; i < pattern.Length; i++)
        {
            for (int j = 0; j < pattern[i].moveScript.Length; j++)
                pattern[i].moveScript[j].SetPatternScript(this);
        }

        if (pattern[0].moveScript.Length > 0)
        {
            pattern[0].moveScript[patternIndex].StartMove();
            curMoveScript = pattern[patternIndex].moveScript[moveIndex];
        }

        if (pattern[0].fireScript.Length > 0)
            for (int i = 0; i < pattern[patternIndex].fireScript.Length; i++)
                pattern[patternIndex].fireScript[i].StartShoot();

    }

    public void NextPattern()
    {
        if(pattern[patternIndex].spellcard)
        {
            BossScript script = gameObject.GetComponent<BossScript>();
            backgroundManager.UnSetSpellcard();
        }

        if (curMoveScript)
        {
            curMoveScript.StopMove();
        }

        for (int j = 0; j < pattern[patternIndex].fireScript.Length; j++)
            pattern[patternIndex].fireScript[j].StopShoot();

        patternIndex++;
        moveIndex = 0;

        if(pattern[patternIndex].spellcard)
        {
            BossScript script = gameObject.GetComponent<BossScript>();
            backgroundManager.SetSpellcard(script.spellBack, script.scrollSpeed);
        }

        pattern[patternIndex].moveScript[moveIndex].StartMove();
        curMoveScript = pattern[patternIndex].moveScript[moveIndex];

        for (int j = 0; j < pattern[patternIndex].fireScript.Length; j++)
            pattern[patternIndex].fireScript[j].StartShoot();
    }

    void RestartPattern()
    {
        if (curMoveScript)
            curMoveScript.StopMove();

        for (int i = 0; i < pattern[patternIndex].fireScript.Length; i++)
            pattern[patternIndex].fireScript[i].StopShoot();

        moveIndex = 0;

        pattern[patternIndex].moveScript[moveIndex].StartMove();
        curMoveScript = pattern[patternIndex].moveScript[moveIndex];

        for (int i = 0; i < pattern[patternIndex].fireScript.Length; i++)
            pattern[patternIndex].fireScript[i].StartShoot();
    }

    public void StopPattern()
    {
        if (curMoveScript)
            curMoveScript.StopMove();

        for (int i = 0; i < pattern[patternIndex].fireScript.Length; i++)
            pattern[patternIndex].fireScript[i].StopShoot();
    }

    public void NextMove()
    {
        curMoveScript.StopMove();
        moveIndex++;
        if (moveIndex < pattern[patternIndex].moveScript.Length)
        {
            pattern[patternIndex].moveScript[moveIndex].StartMove();
            curMoveScript = pattern[patternIndex].moveScript[moveIndex];
        }
        else if (pattern[patternIndex].loop)
        {
            RestartPattern();
        }
        else if (moveIndex >= pattern[patternIndex].moveScript.Length)
        {
            NextPattern();
        }
    }
    */
}
