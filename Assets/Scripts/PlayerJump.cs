using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public GameObject popupDefeat;
    public float jumpForce;
    public int playerId;
    public Sprite[] sprites;
    private SpriteRenderer spr;
    private Rigidbody2D rgb;
    private bool isJumping;
    

    void Start()
    {
        spr = gameObject.GetComponent<SpriteRenderer>();
        rgb = gameObject.GetComponent<Rigidbody2D>();
    }


    public void switchColor(int id)
    {
        if (!isJumping)
        {
            playerId = id;
            spr.sprite = sprites[id];
            isJumping = true;
            rgb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 6) isJumping = false;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Fall")
        {
            Destroy(this.gameObject);
            popupDefeat.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
