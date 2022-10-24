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

    public int phaseIndex = 0;
    int dialogueIndex = 0;
    int item = 0;

    bool bought1 = false;
    bool bought2 = false;
    bool bought3 = false;

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
    public GameObject soldOneButton;
    public GameObject soldTwoButton;
    public GameObject soldThreeButton;
    public GameObject soldOne;
    public GameObject soldTwo;
    public GameObject soldThree;
    public GameObject shadow;
    public GameObject friedSnow;
    public GameObject tomato;
    public GameObject headless;
    public GameObject horseless;
    public GameObject man;

    public TMP_Text choiceOneText;
    public TMP_Text choiceTwoText;
    public TMP_Text nextButtonText;
    public TMP_Text dealButtonText;
    public TMP_Text fakeTwoText;
    public TMP_Text replayButtonText;
    public TMP_Text itemOneText;
    public TMP_Text itemTwoText;
    public TMP_Text itemThreeText;
    public TMP_Text soldOneButtonText;
    public TMP_Text soldTwoButtonText;
    public TMP_Text soldThreeButtonText;

    public TMP_Text dialogueBox;

    public Animator spamtonAnim;

    public Image currentSprite;
    public Sprite idleSprite;
    public Sprite stareSprite;
    public Sprite happySprite;
    public Sprite sadSprite;
    public Sprite shadowSprite;

    public AudioSource mySounds;
    public AudioSource bgm;
    public AudioSource sans;
    public AudioSource bigShot;
    public AudioSource laughtrack;
    public AudioSource wonSound;
    public AudioSource dealDone;
    public AudioSource vineBoom;
    public AudioClip talkSound;
    public AudioClip laughter;
    public AudioClip won;
    public AudioClip boom;

    public bool tomatoWon = false;
    public bool regret = false;

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
        friedSnow.SetActive(false);
        tomato.SetActive(false);
        headless.SetActive(false);
        horseless.SetActive(false);
        man.SetActive(false);

        currentDialogue = phaseZeroDialogue;
        dialogueBox.text = currentDialogue[dialogueIndex];

        spamtonAnim.SetTrigger("isTalking");

        currentSprite = spamton.GetComponent<Image>();

        TalkSound();

    }

    void Update()
    {

        if (choiceOne.activeInHierarchy == false)
        {

            choiceOneText.color = Color.white;

        }

        if (choiceTwo.activeInHierarchy == false)
        {

            choiceTwoText.color = Color.white;

        }

        if (nextButton.activeInHierarchy == false)
        {

            nextButtonText.color = Color.white;

        }

        if (fakeTwo.activeInHierarchy == false)
        {

            fakeTwoText.color = Color.white;

        }

        if (dealButton.activeInHierarchy == false)
        {

            dealButtonText.color = Color.white;

        }

        if (replayButton.activeInHierarchy == false)
        {

            replayButtonText.color = Color.white;

        }

        if (itemOne.activeInHierarchy == false)
        {

            itemOneText.color = Color.white;

        }

        if (itemTwo.activeInHierarchy == false)
        {

            itemTwoText.color = Color.white;

        }

        if (itemThree.activeInHierarchy == false)
        {

            itemThreeText.color = Color.white;

        }

        if (soldOneButton.activeInHierarchy == false)
        {

            soldOneButtonText.color = Color.white;

        }

        if (soldTwoButton.activeInHierarchy == false)
        {

            soldTwoButtonText.color = Color.white;

        }

        if (soldThreeButton.activeInHierarchy == false)
        {

            soldThreeButtonText.color = Color.white;

        }

        if (phaseIndex == 25 && tomatoWon == false)
        {

            GoToNextPhase();

            tomatoWon = true;

        }

    }

    void SetDialogueText()
    {

            dialogueBox.text = currentDialogue[dialogueIndex];
            TalkSound();

    }

    public void AdvanceDialog()
    {

        if (phaseIndex != 7 && phaseIndex != 8 && phaseIndex != 9 && phaseIndex != 13 && phaseIndex != 14 && phaseIndex != 18 && phaseIndex != 20 && phaseIndex != 24 && phaseIndex != 22)
        {

            spamtonAnim.SetTrigger("isTalking");

        }

        if (phaseIndex == 9 && dialogueIndex == 2)
        {

            laughtrack.PlayOneShot(laughter);

        }

        if (phaseIndex == 23 && dialogueIndex == 5)
        {

            nextButton.SetActive(false);
            friedSnow.SetActive(false);
            tomato.SetActive(true);
            dialogueIndex++;
            SetDialogueText();

        }

        if (phaseIndex == 27 && dialogueIndex == 2)
        {

            headless.SetActive(true);

        }

        if (phaseIndex == 27 && dialogueIndex == 4)
        {

            nextButton.SetActive(false);
            choiceOne.SetActive(true);
            choiceTwo.SetActive(true);

        }

        if (phaseIndex == 30 && dialogueIndex == 2)
        {

            man.SetActive(true);
            vineBoom.PlayOneShot(boom);
            StareSprite();

        }

        if (phaseIndex == 25 && dialogueIndex == 1)
        {

            StareSprite();
            dialogueIndex++;
            SetDialogueText();

        }

        else if (dialogueIndex == currentDialogue.Count - 1)
        {
            switch (phaseIndex)
            {

                case 0:
                    phaseIndex = 1;
                    GoToNextPhase();
                    break;
                case 2:
                    phaseIndex = 3;
                    bgm.UnPause();
                    GoToNextPhase();
                    break;
                case 4:
                    phaseIndex = 16;
                    GoToNextPhase();
                    break;
                case 7:
                    phaseIndex = 8;
                    GoToNextPhase();
                    break;
                case 8:
                    phaseIndex = 9;
                    GoToNextPhase();
                    break;
                case 9:
                    phaseIndex = 10;
                    GoToNextPhase();
                    break;
                case 10:
                    phaseIndex = 20;
                    GoToNextPhase();
                    break;
                case 11:
                    phaseIndex = 12;
                    GoToNextPhase();
                    break;
                case 12:
                    phaseIndex = 13;
                    GoToNextPhase();
                    break;
                case 13:
                    phaseIndex = 14;
                    GoToNextPhase();
                    break;
                case 14:
                    phaseIndex = 15;
                    GoToNextPhase();
                    break;
                case 17:
                    if (item == 1)
                    {

                        phaseIndex = 5;

                    }
                    if (item == 2)
                    {

                        phaseIndex = 21;

                    }
                    if (item == 3)
                    {

                        phaseIndex = 26;

                    }
                    GoToNextPhase();
                    break;
                case 18:
                    if (bought1 == true && bought2 == true && bought3 == true)
                    {

                        phaseIndex = 11;

                    }
                    else
                    {

                        phaseIndex = 19;

                    }
                    GoToNextPhase();
                    break;
                case 20:
                    phaseIndex = 18;
                    GoToNextPhase();
                    break;
                case 21:
                    phaseIndex = 24;
                    GoToNextPhase();
                    break;
                case 22:
                    phaseIndex = 23;
                    GoToNextPhase();
                    break;
                case 24:
                    phaseIndex = 22;
                    GoToNextPhase();
                    break;
                case 25:
                    if (bought1 == true && bought2 == true && bought3 == true)
                    {

                        phaseIndex = 11;

                    }
                    else
                    {

                        phaseIndex = 19;

                    }
                    GoToNextPhase();
                    break;
                case 26:
                    phaseIndex = 27;
                    GoToNextPhase();
                    break;
                case 28:
                    phaseIndex = 29;
                    GoToNextPhase();
                    break;
                case 29:
                    phaseIndex = 19;
                    regret = true;
                    GoToNextPhase();
                    break;
                case 30:
                    bought3 = true;
                    if (bought1 == true && bought2 == true && bought3 == true)
                    {

                        phaseIndex = 11;

                    }
                    else
                    {

                        phaseIndex = 19;

                    }
                    GoToNextPhase();
                    break;

            }

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
            bgm.Pause();
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

        else if (phaseIndex == 27)
        {

            phaseIndex = 29;
            GoToNextPhase();

        }

        else if (phaseIndex == 29)
        {

            if (dialogueIndex == 9)
            {

                ShadowSprite();
                shadow.SetActive(true);
                bigShot.Stop();
                vineBoom.Stop();
                spamtonAnim.enabled = false;
                nextButton.SetActive(true);
                choiceOne.SetActive(false);
                choiceTwo.SetActive(false);
                dialogueIndex++;
                SetDialogueText();

            }

            else
            {

                dialogueIndex++;
                SetDialogueText();
                spamtonAnim.SetTrigger("isTalking");
                vineBoom.PlayOneShot(boom);

            }

        }

    }

    public void SureChoice()
    {

        if (phaseIndex == 1 || phaseIndex == 3)
        {

            phaseIndex = 4;
            bgm.UnPause();
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

        else if (phaseIndex == 27)
        {

            phaseIndex = 30;
            GoToNextPhase();

        }

        else if (phaseIndex == 29)
        {

            phaseIndex = 30;
            GoToNextPhase();

        }

    }

    public void Item1()
    {

        phaseIndex = 17;
        item = 1;
        bought1 = true;
        GoToNextPhase();

    }

    public void Item2()
    {

        phaseIndex = 17;
        item = 2;
        bought2 = true;
        GoToNextPhase();

    }

    public void Item3()
    {

        if (regret == false)
        {

            phaseIndex = 17;

        }
        
        else
        {

            phaseIndex = 28;

        }
        item = 3;
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
                ShadowSprite();
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
                bgm.Pause();
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
                bgm.UnPause();
                nextButton.SetActive(false);
                dealButton.SetActive(true);
                fakeTwo.SetActive(true);
                redCross.SetActive(true);
                moss.SetActive(true);
                shadow.SetActive(false);
                spamtonGarbage.SetActive(false);
                StareSprite();
                break;
            case 11:
                phaseIndex = 11;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseElevenDialogue;
                dealDone.Play();
                nextButton.SetActive(true);
                menu.SetActive(true);
                shadow.SetActive(false);
                tomato.SetActive(false);
                friedSnow.SetActive(false);
                man.SetActive(false);
                headless.SetActive(false);
                horseless.SetActive(false);
                spamtonAnim.enabled = true;
                if (bought1 == true)
                {
                    soldOneButton.SetActive(true);
                    soldOne.SetActive(true);
                }
                if (bought2 == true)
                {
                    soldTwoButton.SetActive(true);
                    soldTwo.SetActive(true);
                }
                if (bought3 == true)
                {
                    soldThreeButton.SetActive(true);
                    soldThree.SetActive(true);
                }
                HappySprite();
                break;
            case 12:
                phaseIndex = 12;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseTwelveDialogue;
                nextButton.SetActive(true);
                menu.SetActive(false);
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
                dealDone.Pause();
                nextButton.SetActive(true);
                StareSprite();
                break;
            case 15:
                phaseIndex = 15;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseFifteenDialogue;
                dealDone.UnPause();
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
                currentDialogue = phaseEighteenDialogue;
                bgm.Pause();
                nextButton.SetActive(true);
                StareSprite();
                break;
            case 19:
                phaseIndex = 19;
                spamtonAnim.SetTrigger("isTalking");
                currentDialogue = phaseNineteenDialogue;
                bgm.UnPause();
                dealDone.Stop();
                nextButton.SetActive(false);
                menu.SetActive(true);
                shadow.SetActive(false);
                tomato.SetActive(false);
                friedSnow.SetActive(false);
                man.SetActive(false);
                headless.SetActive(false);
                horseless.SetActive(false);
                spamtonAnim.enabled = true;
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
                IdleSprite();
                break;
            case 20:
                phaseIndex = 20;
                currentDialogue = phaseTwentyDialogue;
                spamtonAnim.SetTrigger("isTalking");
                nextButton.SetActive(true);
                dealButton.SetActive(false);
                fakeTwo.SetActive(false);
                redCross.SetActive(false);
                moss.SetActive(false);
                StareSprite();
                break;
            case 21:
                phaseIndex = 21;
                currentDialogue = phaseTwentyOneDialogue;
                spamtonAnim.SetTrigger("isTalking");
                nextButton.SetActive(true);
                menu.SetActive(false);
                friedSnow.SetActive(true);
                bgm.Pause();
                sans.Play();
                IdleSprite();
                break;
            case 22:
                phaseIndex = 22;
                currentDialogue = phaseTwentyTwoDialogue;
                nextButton.SetActive(true);
                StareSprite();
                break;
            case 23:
                phaseIndex = 23;
                currentDialogue = phaseTwentyThreeDialogue;
                spamtonAnim.enabled = true;
                spamtonAnim.SetTrigger("isTalking");
                nextButton.SetActive(true);
                bigShot.Play();
                StareSprite();
                break;
            case 24:
                phaseIndex = 24;
                currentDialogue = phaseTwentyFourDialogue;
                spamtonAnim.enabled = false;
                sans.Pause();
                nextButton.SetActive(true);
                IdleSprite();
                break;
            case 25:
                phaseIndex = 25;
                currentDialogue = phaseTwentyFiveDialogue;
                spamtonAnim.SetTrigger("isTalking");
                nextButton.SetActive(true);
                wonSound.PlayOneShot(won);
                bigShot.Stop();
                dealDone.Play();
                HappySprite();
                break;
            case 26:
                phaseIndex = 26;
                currentDialogue = phaseTwentySixDialogue;
                spamtonAnim.SetTrigger("isTalking");
                nextButton.SetActive(true);
                horseless.SetActive(true);
                menu.SetActive(false);
                HappySprite();
                break;
            case 27:
                phaseIndex = 27;
                currentDialogue = phaseTwentySevenDialogue;
                bgm.Pause();
                spamtonAnim.enabled = false;
                nextButton.SetActive(true);
                StareSprite();
                break;
            case 28:
                phaseIndex = 28;
                currentDialogue = phaseTwentyEightDialogue;
                spamtonAnim.SetTrigger("isTalking");
                menu.SetActive(false);
                horseless.SetActive(true);
                headless.SetActive(true);
                nextButton.SetActive(true);
                StareSprite();
                break;
            case 29:
                phaseIndex = 29;
                currentDialogue = phaseTwentyNineDialogue;
                spamtonAnim.enabled = true;
                spamtonAnim.SetTrigger("isTalking");
                bigShot.Play();
                bgm.Pause();
                vineBoom.PlayOneShot(boom);
                nextButton.SetActive(false);
                choiceOne.SetActive(true);
                choiceTwo.SetActive(true);
                SadSprite();
                break;
            case 30:
                phaseIndex = 30;
                currentDialogue = phaseThirtyDialogue;
                spamtonAnim.enabled = true;
                spamtonAnim.SetTrigger("isTalking");
                bigShot.Stop();
                dealDone.Play();
                nextButton.SetActive(true);
                choiceOne.SetActive(false);
                choiceTwo.SetActive(false);
                headless.SetActive(false);
                horseless.SetActive(false);
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

    void SadSprite()
    {

        currentSprite.sprite = sadSprite;

    }

    void ShadowSprite()
    {

        currentSprite.sprite = shadowSprite;

    }

    public void TalkSound()
    {

        mySounds.PlayOneShot(talkSound);

    }

}
