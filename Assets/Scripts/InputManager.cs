using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {


    //Singleton
    static InputManager playerController;
    public static InputManager PlayerController { get { return playerController; } }

    public float unfocusSpeed;
    public float focusSpeed;
    public float bombSpeed;
    float ibombSpeed = 1;
    public float speed;
    float bulletBuffer = 0.0f;
    public bool fireButtonDown { get; private set; }
    bool isBombing = false;
    bool isFocused = false;
    public bool canFireOnBomb = true;
    Animator anim;
    Rigidbody2D playerRigidbody;

    void Awake()
    {
        if (playerController != null && playerController != this)
            Destroy(gameObject);
        playerController = this;
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        speed = unfocusSpeed;
    }

    void FixedUpdate()
    {
        if(Time.timeScale > 0)
        {
            //Change player speed on focus button
            if (Input.GetButton("Focus") && !isFocused)
            {
                isFocused = true;
                speed = focusSpeed / ibombSpeed;
                EventManager.Events.SendFocus();
            }
            else if(!Input.GetButton("Focus") && isFocused)
            {
                isFocused = false;
                speed = unfocusSpeed / ibombSpeed;
                EventManager.Events.SendUnfocus();
            }

            //Fire on fire button
            if ((Input.GetButton("Fire")) && (canFireOnBomb || !isBombing))
            {
                fireButtonDown = true;
                bulletBuffer = 0.3f;
            }
            else
            {
                if (bulletBuffer > 0)
                    bulletBuffer -= Time.deltaTime;
                else
                    fireButtonDown = false;
            }

            //Bomb on Bomb Button
            if (Input.GetButtonDown("Bomb"))
            {
                if (PlayerManager.PlayerInfo.bombs > 0)
                {
                    EventManager.Events.SendBombStart();
                }
            }

            //Movement
            float moveX = Input.GetAxisRaw("Horizontal");
            float moveY = Input.GetAxisRaw("Vertical");

            Vector2 movement = new Vector2(moveX, moveY);
            //playerRigidbody.MovePosition(movement * speed);
            playerRigidbody.velocity = movement * speed;
        }
        else if(Time.timeScale == 0)
        {

        }
    }
}
