using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float upForce = 400f;

    private Rigidbody2D rb2d;
    bool canJump = false;

    private void Awake()
    {
        MainMenu.Instance.CallMenu();
    }

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canJump)
        {
            rb2d.velocity = Vector2.zero;
            rb2d.AddForce(new Vector2(0, upForce));
            canJump = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ground" || collision.gameObject.name == "Block")
        {
            canJump = true;
        }
    }

    public void Death()
    {
        Debug.Log("DEAD");
        Destroy(gameObject);
        MainMenu.Instance.CallMenu();
    }
}
