using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringScript : MonoBehaviour {
    /*
    PlayerManagerScript playerManager;

    int stage = 1;
    int stagePoint;
    int power;
    int graze;
    int point;
    int total;

    int player;
    int bomb;

    public Text stageText;
    public Text powerText;
    public Text grazeText;
    public Text pointText;
    public Text totalText;
    public Text playerText;
    public Text bombText;
    public Text finalText;

    void Awake()
    {
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManagerScript>();
    }

    public void CalcFinal()
    {
        CalcScore();
        StopAllCoroutines();
        player = playerManager.lives * 3000000;
        bomb = playerManager.bombs * 1000000;
        total += player + bomb;
        int final = playerManager.score + total;

        playerText.text = player.ToString();
        bombText.text = bomb.ToString();
        totalText.text = total.ToString();
        finalText.text = final.ToString();


        gameObject.transform.GetChild(6).gameObject.SetActive(true);
        gameObject.transform.GetChild(7).gameObject.SetActive(true);
        gameObject.transform.GetChild(8).gameObject.SetActive(true);
    }

    public void CalcScore()
    {
        stagePoint = stage * 1000;
        power = playerManager.power * 100;
        graze = playerManager.graze * 10;
        point = playerManager.point;

        total = (stagePoint + power + graze) * point;

        stageText.text = stagePoint.ToString();
        powerText.text = power.ToString();
        grazeText.text = graze.ToString();
        pointText.text = point.ToString();
        totalText.text = total.ToString();

        playerManager.ResetGraze();
        playerManager.ResetPoint();

        StartCoroutine(ShowScore());
    }

    IEnumerator ShowScore()
    {
        for(int i = 0; i < 6; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(true);
        }

        yield return new WaitForSeconds(3);

        for (int i = 0; i < 6; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }

        playerManager.AddScore(total);
        stage++;
    }
    */
}
