using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{

    //Singleton
    static UIScript uIManager;
    public static UIScript UIManager { get { return uIManager; } }

    public Transform pause;
    public Transform FPS;
    public Transform info;
    public Transform score;
    public Transform stage;
    public Transform boss;
    public Transform select;

    void Awake()
    {
        if (uIManager != null && uIManager != this)
            Destroy(gameObject);
        uIManager = this;
    }

    void OnEnable()
    {
        EventManager.Events.OnPause += ActivatePause;
        EventManager.Events.OnGameLoad += ActivateFPS;
        EventManager.Events.OnGameLoad += ActivateSelect;
        EventManager.Events.OnGameStart += ActivateInfo;
        EventManager.Events.OnBossEnter += ActivateBoss;
        EventManager.Events.OnStageStart += ActivateStage;
        EventManager.Events.OnStageEnd += ActivateScore;

        EventManager.Events.OnBossExit += DeactivateBoss;
        EventManager.Events.OnUnpause += DeactivatePause;
        EventManager.Events.OnStageEnd += DeactivateScore;
    }

    void OnDisable()
    {
        EventManager.Events.OnPause -= ActivatePause;
        EventManager.Events.OnGameLoad -= ActivateFPS;
        EventManager.Events.OnGameLoad -= ActivateSelect;
        EventManager.Events.OnGameStart -= ActivateInfo;
        EventManager.Events.OnBossEnter -= ActivateBoss;
        EventManager.Events.OnStageStart -= ActivateStage;
        EventManager.Events.OnStageEnd -= ActivateScore;

        EventManager.Events.OnBossExit -= DeactivateBoss;
        EventManager.Events.OnUnpause -= DeactivatePause;
        EventManager.Events.OnStageEnd -= DeactivateScore;
    }

    void ActivateUI(Transform uiObject)
    {
        for (int i = 0; i < uiObject.childCount; i++)
            uiObject.GetChild(i).gameObject.SetActive(true);
    }

    void DeactiveateUI(Transform uiObject)
    {
        for (int i = 0; i < uiObject.childCount; i++)
            uiObject.GetChild(i).gameObject.SetActive(false);
    }

    void ActivatePause() { ActivateUI(pause); }
    void ActivateFPS() { ActivateUI(FPS); }
    void ActivateInfo() { ActivateUI(info); }
    void ActivateScore() { ActivateUI(score); }
    void ActivateStage(Material mat, Vector2 vec) { ActivateUI(stage); }
    void ActivateBoss() { ActivateUI(boss); }
    void ActivateSelect() { ActivateUI(select); }

    void DeactivatePause() { DeactiveateUI(pause); }
    void DeactivateFPS() { DeactiveateUI(FPS); }
    void DeactivateInfo() { DeactiveateUI(info); }
    void DeactivateScore() { DeactiveateUI(score); }
    void DeactivateStage() { DeactiveateUI(stage); }
    void DeactivateBoss() { DeactiveateUI(boss); }
    void DeactivateSelect() { DeactiveateUI(select); }
}
