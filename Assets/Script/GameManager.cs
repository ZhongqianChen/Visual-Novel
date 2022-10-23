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
    int item = 0;

    bool bought1 = false;
    bool bought2 = false;
    bool bought3 = false;
    bool bought4 = false;

    public GameObject choiceOne;
    public GameObject choiceTwo;
    public GameObject nextButton;
    public GameObject moss;
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
    public GameObject soldOneButton;
    public GameObject soldTwoButton;
    public GameObject soldThreeButton;
    public GameObject soldFourButton;
    public GameObject soldOne;
    public GameObject soldTwo;
    public GameObject soldThree;
    public GameObject soldFour;
    public GameObject shadow;

    public TMP_Text dialogueBox;

    public Animator spamtonAnim;

    public Image currentSprite;
    public Sprite idleSprite;
    public Sprite stareSprite;
    public Sprite happySprite;
    public Sprite sadSprite;

    void Start()
    {
        
        GameObject spamton = GameObject.FindWithTag("Spamton");

        nextButton.SetActive(true);
        choiceOne.SetActive(false);
        choiceTwo.SetActive(false);
        moss.SetActive(false);
        spamtonGarbage.SetActive(false);
        dealButton.SetActive(false);
        fakeTwo.SetActive(false);
        redCross.SetActive(false);
        replayButton.SetActive(false);
        menu.SetActive(false);
        shadow.SetActive(false);

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
                    phaseIndex = 16;
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
                    phaseIndex = 18;
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
                case 17:
                    if (item == 1)
                    {

                        phaseIndex = 5;

                    }
                    break;
                case 18:
                    phaseIndex = 19;
                    bought1 = true;
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

    public void Item1()
    {

        phaseIndex = 17;
        item = 1;
        GoToNextPhase();

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
                shadow.SetActive(true);
                StareSprite();
                break;
            case 3:
                phaseIndex = 3;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseThreeDialogue;
                nextButton.SetActive(false);
                choiceOne.SetActive(true);
                choiceTwo.SetActive(true);
                shadow.SetActive(false);
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
                menu.SetActive(false);
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
                spamtonGarbage.SetActive(true);
                SadSprite();
                break;
            case 7:
                phaseIndex = 7;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseSevenDialogue;
                nextButton.SetActive(true);
                choiceOne.SetActive(false);
                choiceTwo.SetActive(false);
                moss.SetActive(true);
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
                shadow.SetActive(true);
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
                shadow.SetActive(false);
                spamtonGarbage.SetActive(false);
                SadSprite();
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
            case 16:
                phaseIndex = 16;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseSixteenDialogue;
                nextButton.SetActive(false);
                menu.SetActive(true);
                if (bought1 == true)
                {
                    soldOneButton.SetActive(true);
                    soldOne.SetActive(true);
                }
                else
                {
                    soldOneButton.SetActive(false);
                    soldOne.SetActive(false);
                }
                if (bought2 == true)
                {
                    soldTwoButton.SetActive(true);
                    soldTwo.SetActive(true);
                }
                else
                {
                    soldTwoButton.SetActive(false);
                    soldTwo.SetActive(false);
                }
                if (bought3 == true)
                {
                    soldThreeButton.SetActive(true);
                    soldThree.SetActive(true);
                }
                else
                {
                    soldThreeButton.SetActive(false);
                    soldThree.SetActive(false);
                }
                if (bought4 == true)
                {
                    soldFourButton.SetActive(true);
                    soldFour.SetActive(true);
                }
                else
                {
                    soldFourButton.SetActive(false);
                    soldFour.SetActive(false);
                }
                IdleSprite();
                break;
            case 17:
                phaseIndex = 17;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseSeventeenDialogue;
                nextButton.SetActive(true);
                menu.SetActive(false);
                IdleSprite();
                break;
            case 18:
                phaseIndex = 18;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseEighteenDialogue;
                nextButton.SetActive(true);
                dealButton.SetActive(false);
                fakeTwo.SetActive(false);
                redCross.SetActive(false);
                moss.SetActive(false);
                shadow.SetActive(true);
                StareSprite();
                break;
            case 19:
                phaseIndex = 19;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseNineteenDialogue;
                nextButton.SetActive(false);
                menu.SetActive(true);
                shadow.SetActive(false);
                if (bought1 == true)
                {
                    soldOneButton.SetActive(true);
                    soldOne.SetActive(true);
                }
                else
                {
                    soldOneButton.SetActive(false);
                    soldOne.SetActive(false);
                }
                if (bought2 == true)
                {
                    soldTwoButton.SetActive(true);
                    soldTwo.SetActive(true);
                }
                else
                {
                    soldTwoButton.SetActive(false);
                    soldTwo.SetActive(false);
                }
                if (bought3 == true)
                {
                    soldThreeButton.SetActive(true);
                    soldThree.SetActive(true);
                }
                else
                {
                    soldThreeButton.SetActive(false);
                    soldThree.SetActive(false);
                }
                if (bought4 == true)
                {
                    soldFourButton.SetActive(true);
                    soldFour.SetActive(true);
                }
                else
                {
                    soldFourButton.SetActive(false);
                    soldFour.SetActive(false);
                }
                IdleSprite();
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

    void SadSprite()
    {

        currentSprite.sprite = sadSprite;

    }

}
