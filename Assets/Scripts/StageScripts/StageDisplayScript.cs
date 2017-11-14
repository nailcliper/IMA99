using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageDisplayScript : MonoBehaviour {
    int stageNum = 0;
    char[] stageChars = { 'S', 't', 'a', 'g', 'e', ' ','0'};
    public Text stageText;
    Color32 white = new Color32(255, 255, 255, 255);
    Color32 blank = new Color32(255, 255, 255, 0);

    public void Display(int num)
    {
        Coroutine routine = StartCoroutine(DisplayText(num));
    }

    IEnumerator DisplayText(int num)
    {
        stageNum = num;
        stageChars[6] = stageNum.ToString().ToCharArray()[0];
        stageText.text = "";
        stageText.color = white;
        int i = 0;
        while (i < stageChars.Length)
        {
            stageText.text += stageChars[i];
            yield return new WaitForSeconds(0.1f);
            i++;
        }

        yield return new WaitForSeconds(1f);
        float j = 0;
        while (j < 1)
        {
            j += Time.deltaTime;
            stageText.color = Color32.Lerp(white, blank, j);
            yield return new WaitForFixedUpdate();
        }

    }
}
