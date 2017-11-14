using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoUI : MonoBehaviour {

    //Singleton
    static PlayerInfoUI playerInfo;
    public static PlayerInfoUI PlayerInfo { get { return playerInfo; } }

    public Text scoreText;
    public Text playerText;
    public Text bombText;
    public Text powerText;
    public Text grazeText;
    public Text pointText;

    void Awake()
    {
        if (playerInfo != null && playerInfo != this)
            Destroy(gameObject);
        playerInfo = this;

        UpdatePlayer();
        UpdateBomb();
        UpdatePower();
        UpdateGraze();
        UpdatePoint();
    }

    IEnumerator UpdateScoreRoutine(Text _text, int value)
    {
        int startVal = PlayerManager.PlayerInfo.score;
        int endVal = startVal + value;
        float rate = ((float)value/ 7.17f);
        if (rate < 1)
            rate = 1;
        while(startVal < endVal)
        {
            startVal = (int)Mathf.MoveTowards(startVal, endVal,rate);
            _text.text = startVal.ToString("000000000");
            yield return new WaitForFixedUpdate();
        }
        _text.text = endVal.ToString("000000000");
    }

    public void UpdateScore(int value) { StartCoroutine(UpdateScoreRoutine(scoreText, value)); }
    public void UpdatePlayer() { playerText.text = PlayerManager.PlayerInfo.lives.ToString(); }
    public void UpdateBomb() { bombText.text = PlayerManager.PlayerInfo.bombs.ToString(); }

    public void UpdateGraze(){ grazeText.text = PlayerManager.PlayerInfo.graze.ToString("##0"); }
    public void UpdatePoint() { pointText.text = PlayerManager.PlayerInfo.point.ToString("##0"); }

    public void UpdatePower()
    {
        if(PlayerManager.PlayerInfo.power >= 128)
            powerText.text = "MAX";
        else
            powerText.text = PlayerManager.PlayerInfo.power.ToString("##0");
    }
}
