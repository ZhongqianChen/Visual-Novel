using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TomatoSmash : MonoBehaviour
{

    public GameObject tomato;
    public Image currentSprite;
    public Sprite transform1;
    public Sprite transform2;
    public Sprite transform3;
    public Sprite ketchup;
    public AudioSource sfx;
    public AudioClip punch;

    public GameObject manager;
    public GameManager script;

    public int counter = 0;

    void Start()
    {

        currentSprite = tomato.GetComponent<Image>();

        script = manager.GetComponent<GameManager>();

    }

    public void Hit()
    {

        counter++;

        sfx.PlayOneShot(punch);

    }

    void Update()
    {

        if (counter == 15)
        {

            currentSprite.sprite = transform1;

        }

        if (counter == 30)
        {

            currentSprite.sprite = transform2;

        }

        if (counter == 45)
        {

            currentSprite.sprite = transform3;

        }

        if (counter == 60)
        {

            currentSprite.sprite = ketchup;

            script.phaseIndex = 25;

        }

    }

}
