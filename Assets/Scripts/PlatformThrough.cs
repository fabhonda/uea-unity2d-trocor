using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformThrough : MonoBehaviour
{

    public int id;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Collider")
        {
            var scriptPlayerJump = collision.gameObject.GetComponentInParent<PlayerJump>();
            if (id == scriptPlayerJump.playerId)
            {
                gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            //collision.transform.parent = this.transform;
        }
    }
}
