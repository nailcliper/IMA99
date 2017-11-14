using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundTilingScript : MonoBehaviour {
    public Vector2 scrollSpeed;
    private Vector2 startOffset;
    public Color32 startColor;
    Material mat;
    Renderer backRenderer;
    Coroutine scroll;
    Coroutine fade;
    float x = 0;
    float y = 0;

    Dictionary<string, Color32> colors = new Dictionary<string, Color32>(); 
    static Color32 full = new Color32(255, 255, 255, 255);
    static Color32 half = new Color32(255,255,255,128);
    static Color32 clear = new Color32(255, 255, 255, 0);
    static Color32 black = new Color32(0, 0, 0, 0);

    Coroutine fadeRoutine;

    void Awake()
    {
        colors.Add("full", full);
        colors.Add("half", half);
        colors.Add("clear", clear);
        colors.Add("black", black);

        backRenderer = gameObject.GetComponent<Renderer>();
        mat = backRenderer.sharedMaterial;
        startOffset = mat.GetTextureOffset("_MainTex");
        startColor = mat.color;
        scroll = StartCoroutine(Scroll());
    }

    void OnDisable()
    {
        StopAllCoroutines();
        mat.SetTextureOffset("_MainTex", startOffset);
        mat.color = startColor;
    }

    IEnumerator Scroll()
    {
        while (true)
        {
            x = Mathf.Repeat((Time.time * scrollSpeed.x) + startOffset.x, 1);
            y = Mathf.Repeat((Time.time * scrollSpeed.y) + startOffset.y, 1);

            Vector2 offset = new Vector2(x, y);

            mat.SetTextureOffset("_MainTex", offset);

            yield return new WaitForEndOfFrame();
        }
    }

    public void SetMaterial(Material m)
    {
        mat.SetTextureOffset("_MainTex", startOffset);
        mat.color = startColor;
        backRenderer.sharedMaterial = m;
        mat = m;
        startOffset = mat.GetTextureOffset("_MainTex");
        startColor = mat.color;
    }

    public void SetColor(string color) {
        if(mat)
            mat.color = colors[color];
    }

    public void FadeFull(float time = 1, float wait = 0) { fadeRoutine = StartCoroutine(Fade(255, time, wait)); }
    public void FadeHalf(float time = 1, float wait = 0) { fadeRoutine = StartCoroutine(Fade(128, time, wait)); }
    public void FadeClear(float time = 1, float wait = 0) { fadeRoutine = StartCoroutine(Fade(0, time, wait)); }

    IEnumerator Fade(byte endAlpha = 0, float time = 1, float wait = 0)
    {
        if (wait > 0)
            yield return new WaitForSeconds(wait);

        Color32 curColor = mat.color;
        byte startAlpha = curColor.a;
        float t = 0;
        while (t < 1)
        {
            if (time > 0)
                t += Time.deltaTime / time;
            else
                t = 1;

            mat.color = new Color32(startColor.r, startColor.g, startColor.b, (byte)Mathf.Lerp(startAlpha, endAlpha, t));

            yield return new WaitForFixedUpdate();
        }
    }
}
