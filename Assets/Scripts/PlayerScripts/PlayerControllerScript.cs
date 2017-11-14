using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerScript : MonoBehaviour {
    /*
    public static PlayerControllerScript current;
    public float unfocusSpeed;
    public float focusSpeed;
    public float bombSpeed;
    float ibombSpeed = 1;
    public float speed;
    bool fireButtonDown = false;
    bool isBombing = false;
    public bool canFireOnBomb = true;
    Animator anim;
    public PlayerManagerScript playerManager;
    public BombFireScript bombScript;

    void Awake ()
    {
        current = this;
        playerManager = GameObject.FindGameObjectWithTag("PlayerManager").GetComponent<PlayerManagerScript>();
        bombScript = gameObject.GetComponent<BombFireScript>();
    }

	void Start () {
        anim = GetComponent<Animator>();
        fireButtonDown = false;
    }

    private void OnEnable()
    {
        fireButtonDown = false;
        isBombing = false;
    }
	
	void Update () {
        if (Time.timeScale > 0)
        {
            //Change player speed on focus button
            if (Input.GetButton("Focus"))
            {
                playerManager.SetIsFocused();
                speed = focusSpeed / ibombSpeed;
            }
            else
            {
                playerManager.SetIsFocused(false);
                speed = unfocusSpeed / ibombSpeed;
            }

            //Fire on fire button
            if ((Input.GetButton("Fire")) && (canFireOnBomb || !isBombing))
            {
                fireButtonDown = true;
                CancelInvoke("BulletBuffer");
            }
            else
            {
                Invoke("BulletBuffer", 0.2f);
            }

            //Bomb on Bomb Button
            if (Input.GetButtonDown("Bomb"))
            {
                if (playerManager.GetBomb() > 0)
                {
                    if (!isBombing)
                    {
                        isBombing = true;
                        bombScript.FireBomb();
                        Invoke("ResetBombBool", bombScript.GetDuration());
                        StartCoroutine(SetBombSpeed());
                    }
                }
            }

        }

        //Movement
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        anim.SetFloat("XVelocity", moveX);

        var movement = new Vector2(moveX, moveY);
        var rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = movement * speed;
	}

    void BulletBuffer()
    {
        fireButtonDown = false;
    }

    //Returns fire button bool (for BulletFireScript)
    public bool GetFireBool()
    {
        return fireButtonDown;
    }

    public bool GetBombBool()
    {
        return isBombing;
    }

    public void ResetBombBool()
    {
        isBombing = false;
        playerManager.SetIsBombing(false);
    }

    IEnumerator SetBombSpeed()
    {
        float i = 0;
        float rate = 1 / (bombScript.GetDuration() - 0.5f);

        while (i < 1)
        {
            i += Time.deltaTime * rate;
            ibombSpeed = Mathf.Lerp(bombSpeed, 1, i);
            yield return new WaitForFixedUpdate();
        }
    }

    void OnDisable()
    {
        isBombing = false;
        ibombSpeed = 1;
        CancelInvoke();
    }
    */
}
