using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeScript : MonoBehaviour {
    /*
    //public float speed;
    //public float unfocusA;
    //public float focusA;
    //float curA;
    PlayerManagerScript playerManager;
    bool isFocused = false;
    //float thisA;
    //Vector3 focusScale = new Vector3(1.5f, 1.5f, 1);
    Animator animator;

    void Awake()
    {
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManagerScript>();
        //thisA = gameObject.GetComponent<SpriteRenderer>().color.a;
        animator = gameObject.GetComponent<Animator>();
    }

    void OnEnable()
    {
        animator.Play("Unfocus");
        //transform.localScale = new Vector3(0, 0, 1);
        //thisA = unfocusA;
        isFocused = false;
    }

    /*
    void OnDisable()
    {
        StopCoroutine(ChangeAlpha());
    }
    */
    /*
    void Update()
    {
        if (isFocused != playerManager.IsFocused())
            FlipFocus();
    }

    void FlipFocus()
    {
        isFocused = !isFocused;
        if (isFocused)
        {
            animator.Play("Focus");
            //StartCoroutine(ChangeAlpha());
        }
        else
        {
            animator.Play("Unfocus");
            //StopCoroutine(ChangeAlpha());
            //transform.localScale = new Vector3(0, 0, 1);
            //thisA = unfocusA;
        }
    }
    */
    /*
    protected IEnumerator ChangeAlpha()
    {
        while (thisA != focusA || transform.localScale != focusScale)
        {
            thisA = Mathf.MoveTowards(thisA, focusA, speed * Time.deltaTime);
            transform.localScale = Vector3.MoveTowards(transform.localScale, focusScale, speed * Time.deltaTime);
            yield return new WaitForFixedUpdate();
        }
    }
    */
}
