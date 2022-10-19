using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public List<string> phaseZeroDialogue;
    public List<string> phaseOneDialogue;
    public List<string> phaseTwoDialogue;
    public List<string> phaseThreeDialogue;
    public List<string> phaseFourDialogue;
    public List<string> phaseFiveDialogue;
    public List<string> phaseSixDialogue;
    public List<string> phaseSevenDialogue;
    public List<string> phaseEightDialogue;
    public List<string> phaseNineDialogue;
    public List<string> phaseTenDialogue;
    public List<string> phaseElevenDialogue;
    public List<string> phaseTwelveDialogue;
    public List<string> phaseThirteenDialogue;
    public List<string> phaseFourteenDialogue;
    public List<string> phaseFifteenDialogue;
    public List<string> phaseSixteenDialogue;
    public List<string> phaseSeventeenDialogue;
    public List<string> phaseEighteenDialogue;
    public List<string> phaseNineteenDialogue;
    public List<string> phaseTwentyDialogue;
    public List<string> phaseTwentyOneDialogue;
    public List<string> phaseTwentyTwoDialogue;
    public List<string> phaseTwentyThreeDialogue;
    public List<string> phaseTwentyFourDialogue;
    public List<string> phaseTwentyFiveDialogue;
    public List<string> phaseTwentySixDialogue;
    public List<string> phaseTwentySevenDialogue;
    public List<string> phaseTwentyEightDialogue;
    public List<string> phaseTwentyNineDialogue;
    public List<string> phaseThirtyDialogue;
    public List<string> phaseThirtyOneDialogue;

    List<string> currentDialogue;

    int phaseIndex = 0;
    int dialogueIndex = 0;

    public GameObject choiceOne;
    public GameObject choiceTwo;
    public GameObject nextButton;
    public GameObject moss;
    public GameObject spamtonSad;
    public GameObject spamtonGarbage;
    public GameObject dealButton;
    public GameObject fakeTwo;
    public GameObject redCross;
    public GameObject replayButton;
    public GameObject menu;
    public GameObject itemOne;
    public GameObject itemTwo;
    public GameObject itemThree;
    public GameObject itemFour;

    public TMP_Text dialogueBox;

    public Animator spamtonAnim;

    public Image currentSprite;
    public Sprite idleSprite;
    public Sprite stareSprite;
    public Sprite happySprite;

    void Start()
    {
        
        GameObject spamton = GameObject.FindWithTag("Spamton");

        nextButton.SetActive(true);
        choiceOne.SetActive(false);
        choiceTwo.SetActive(false);
        moss.SetActive(false);
        spamtonSad.SetActive(false);
        spamtonGarbage.SetActive(false);
        dealButton.SetActive(false);
        fakeTwo.SetActive(false);
        redCross.SetActive(false);
        replayButton.SetActive(false);
        menu.SetActive(false);

        currentDialogue = phaseZeroDialogue;
        dialogueBox.text = currentDialogue[dialogueIndex];

        spamtonAnim.SetTrigger("isTalking");

        currentSprite = spamton.GetComponent<Image>();

    }

    void SetDialogueText()
    {

            dialogueBox.text = currentDialogue[dialogueIndex];

    }

    public void AdvanceDialog()
    {

        if (phaseIndex != 7 && phaseIndex != 8 && phaseIndex != 9 && phaseIndex != 13 && phaseIndex != 14)
        {

            spamtonAnim.SetTrigger("isTalking");

        }

        if (dialogueIndex == currentDialogue.Count - 1)
        {
            switch (phaseIndex)
            {

                case 0:
                    phaseIndex = 1;
                    break;
                case 2:
                    phaseIndex = 3;
                    break;
                case 4:
                    phaseIndex = 5;
                    break;
                case 7:
                    phaseIndex = 8;
                    break;
                case 8:
                    phaseIndex = 9;
                    break;
                case 9:
                    phaseIndex = 10;
                    break;
                case 10:
                    phaseIndex = 11;
                    break;
                case 11:
                    phaseIndex = 12;
                    break;
                case 12:
                    phaseIndex = 13;
                    break;
                case 13:
                    phaseIndex = 14;
                    break;
                case 14:
                    phaseIndex = 15;
                    break;

            }

            GoToNextPhase();

        }

        else
        {

            dialogueIndex++;

            SetDialogueText();

        }

    }

    public void NahChoice()
    {

        if (phaseIndex == 1 || phaseIndex == 3)
        {

            phaseIndex = 2;
            GoToNextPhase();

        }

        else if (phaseIndex == 5)
        {

            phaseIndex = 6;
            GoToNextPhase();

        }

        else if (phaseIndex == 6)
        {

            phaseIndex = 10;
            GoToNextPhase();

        }

    }

    public void SureChoice()
    {

        if (phaseIndex == 1 || phaseIndex == 3)
        {

            phaseIndex = 4;
            GoToNextPhase();

        }

        else if (phaseIndex == 5)
        {

            phaseIndex = 7;
            GoToNextPhase();

        }

        else if (phaseIndex == 6)
        {

            phaseIndex = 7;
            GoToNextPhase();

        }

    }

    void GoToNextPhase()
    {

        nextButton.SetActive(false);
        choiceOne.SetActive(false);
        choiceTwo.SetActive(false);

        dialogueIndex = 0;

        switch (phaseIndex)
        {

            case 1:
                phaseIndex = 1;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseOneDialogue;
                nextButton.SetActive(false);
                choiceOne.SetActive(true);
                choiceTwo.SetActive(true);
                break;
            case 2:
                phaseIndex = 2;
                currentDialogue = phaseTwoDialogue;
                nextButton.SetActive(true);
                StareSprite();
                break;
            case 3:
                phaseIndex = 3;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseThreeDialogue;
                nextButton.SetActive(false);
                choiceOne.SetActive(true);
                choiceTwo.SetActive(true);
                IdleSprite();
                break;
            case 4:
                phaseIndex = 4;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseFourDialogue;
                nextButton.SetActive(true);
                choiceOne.SetActive(false);
                choiceTwo.SetActive(false);
                HappySprite();
                break;
            case 5:
                phaseIndex = 5;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseFiveDialogue;
                nextButton.SetActive(false);
                choiceOne.SetActive(true);
                choiceTwo.SetActive(true);
                moss.SetActive(true);
                HappySprite();
                break;
            case 6:
                phaseIndex = 6;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseSixDialogue;
                nextButton.SetActive(false);
                choiceOne.SetActive(true);
                choiceTwo.SetActive(true);
                moss.SetActive(false);
                spamtonSad.SetActive(true);
                spamtonGarbage.SetActive(true);
                StareSprite();
                break;
            case 7:
                phaseIndex = 7;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseSevenDialogue;
                nextButton.SetActive(true);
                choiceOne.SetActive(false);
                choiceTwo.SetActive(false);
                moss.SetActive(true);
                spamtonSad.SetActive(false);
                spamtonGarbage.SetActive(false);
                HappySprite();
                break;
            case 8:
                phaseIndex = 8;
                currentDialogue = phaseEightDialogue;
                nextButton.SetActive(true);
                HappySprite();
                break;
            case 9:
                phaseIndex = 9;
                currentDialogue = phaseNineDialogue;
                nextButton.SetActive(true);
                StareSprite();
                break;
            case 10:
                phaseIndex = 10;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseTenDialogue;
                nextButton.SetActive(false);
                dealButton.SetActive(true);
                fakeTwo.SetActive(true);
                redCross.SetActive(true);
                moss.SetActive(true);
                spamtonSad.SetActive(false);
                spamtonGarbage.SetActive(false);
                StareSprite();
                break;
            case 11:
                phaseIndex = 11;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseElevenDialogue;
                nextButton.SetActive(true);
                dealButton.SetActive(false);
                fakeTwo.SetActive(false);
                redCross.SetActive(false);
                moss.SetActive(false);
                HappySprite();
                break;
            case 12:
                phaseIndex = 12;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseTwelveDialogue;
                nextButton.SetActive(true);
                IdleSprite();
                break;
            case 13:
                phaseIndex = 13;
                currentDialogue = phaseThirteenDialogue;
                nextButton.SetActive(true);
                break;
            case 14:
                phaseIndex = 14;
                currentDialogue = phaseFourteenDialogue;
                nextButton.SetActive(true);
                StareSprite();
                break;
            case 15:
                phaseIndex = 15;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseFifteenDialogue;
                nextButton.SetActive(false);
                replayButton.SetActive(true);
                HappySprite();
                break;

        }

        SetDialogueText();

    }

    void IdleSprite()
    {

        currentSprite.sprite = idleSprite;

    }

    void StareSprite()
    {

        currentSprite.sprite = stareSprite;

    }

    void HappySprite()
    {

        currentSprite.sprite = happySprite;

    }

}
