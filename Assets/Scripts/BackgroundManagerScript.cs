using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundManagerScript : MonoBehaviour {

    //Singleton
    static BackgroundManagerScript backgroundManager;
    public static BackgroundManagerScript BackgroundManager { get { return backgroundManager; } }

    BackgroundTilingScript bgScript;
    BackgroundTilingScript spScript;
    BackgroundTilingScript blScript;

    //public GameObject background;
    //public GameObject spellcard;
    //public GameObject blackground;
    //public GameObject foreground;

    void Awake()
    {
        if (backgroundManager != null && backgroundManager != this)
            Destroy(gameObject);
        backgroundManager = this;

        //background = gameObject.transform.Find("Background").gameObject;
        bgScript = gameObject.transform.Find("Background").gameObject.GetComponent<BackgroundTilingScript>();
        bgScript.SetColor("clear");
        //foreground = background;

        //spellcard = gameObject.transform.Find("Spellcard").gameObject;
        spScript = gameObject.transform.Find("Spellcard").gameObject.GetComponent<BackgroundTilingScript>();
        spScript.SetColor("clear");

        //blackground = gameObject.transform.Find("Blackground").gameObject;
        blScript = gameObject.transform.Find("Blackground").gameObject.GetComponent<BackgroundTilingScript>();
        blScript.SetColor("black");
    }

    void OnEnable()
    {
        EventManager.Events.OnStageStart += SetBackground;
        EventManager.Events.OnSpellStart += SetSpellcard;
        EventManager.Events.OnBossNextLife += UnSetSpellcard;
        EventManager.Events.OnBossExit += UnSetSpellcard;
        EventManager.Events.OnBombStart += DarkenBackground;
    }

    void OnDisable()
    {
        EventManager.Events.OnStageStart -= SetBackground;
        EventManager.Events.OnSpellStart -= SetSpellcard;
        EventManager.Events.OnBossNextLife -= UnSetSpellcard;
        EventManager.Events.OnBossExit -= UnSetSpellcard;
        EventManager.Events.OnBombStart -= DarkenBackground;
    }

    public void SetBackground(Material bg, Vector2 scrollSpeed)
    {
        Coroutine backRoutine = StartCoroutine(SetBack(bg, scrollSpeed));
    }

    IEnumerator SetBack(Material bg, Vector2 scrollSpeed)
    {
        bgScript.FadeClear(0.75f);
        yield return new WaitForSeconds(0.75f);
        bgScript.SetMaterial(bg);
        bgScript.scrollSpeed = scrollSpeed;
        bgScript.SetColor("clear");
        bgScript.FadeFull();
    }

    public void SetSpellcard(Material sp, Vector2 scrollSpeed)
    {
        bgScript.FadeClear(0.75f);
        spScript.SetMaterial(sp);
        spScript.scrollSpeed = scrollSpeed;
        spScript.SetColor("clear");
        spScript.FadeFull(0.75f);
        //foreground = spellcard;
    }

    public void UnSetSpellcard()
    {
        bgScript.FadeFull(0.25f);
        spScript.FadeClear(0.25f);
        //foreground = background;
    }

    public void DarkenBackground()
    {
        blScript.FadeHalf(0.5f);
    }

    public void UndarkenBackground()
    {
        blScript.FadeClear(0.5f);
    }
}
