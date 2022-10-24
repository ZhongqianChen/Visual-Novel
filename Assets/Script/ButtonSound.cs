using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class ButtonSound : MonoBehaviour
{

    public AudioSource mySounds;
    public AudioClip hoverSound;
    public AudioClip clickSound;

    public TMP_Text dialogueBox;

    public void HoverSound()
    {

        mySounds.PlayOneShot(hoverSound);

    }

    public void ClickSound()
    {

        mySounds.PlayOneShot(clickSound);

    }

    public void ChangeColor()
    {

        dialogueBox.color = Color.yellow;

    }

    public void ChangeBack()
    {

        dialogueBox.color = Color.white;

    }

}
