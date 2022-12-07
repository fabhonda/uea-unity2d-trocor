using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StarCollected : MonoBehaviour
{

    public AudioClip sfxCollected;
    public GameObject popupVictory;

    void Awake()
    {
        Time.timeScale = 1;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            var sfx = this.gameObject.GetComponent<AudioSource>();
            sfx.PlayOneShot(sfxCollected);
            this.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            Time.timeScale = 0;
            popupVictory.SetActive(true);
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().name, 1);
        }
    }
    
}
