using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //these lists have all the dialogue for each phase of questions
    public List<string> phaseOneDialogue;
    public List<string> phaseTwoDialogue;
    public List<string> phaseThreeDialogue;
    public List<string> phaseFourDialogue;

    //holds the phase we're currently going through
    List<string> currentDialogue;

    //tracks the current phase and the line we're on in that phase
    int phaseIndex = 0;
    int dialogueIndex = 0;

    //game object for all buttons
    public GameObject choiceOne;
    public GameObject choiceTwo;
    public GameObject nextButton;

    //text component that is showing the dialogue
    public TMP_Text dialogueBox;

    //"score" for how much of a clown u r
    //int clownyLove = 0;

    //text for results of the quiz
    //public string clownMessage;
    //public string notAClownMessage;

    //animator components for each face
    //public Animator faceyAnim;
    //public Animator clownyAnim;

    // Start is called before the first frame update
    void Start()
    {
        //turn off the choice buttons
        choiceOne.SetActive(false);
        choiceTwo.SetActive(false);
        //start the dialogue
        currentDialogue = phaseOneDialogue;
        dialogueBox.text = currentDialogue[dialogueIndex];
        //faceyAnim.SetTrigger("isTalking");
    }

    void SetDialogueText()
    {
        //if we haven't gotten our results yet
        if (phaseIndex < 4)
        {
            //set the dialogue component to show the line we're on
            dialogueBox.text = currentDialogue[dialogueIndex];
        }
    }

    public void AdvanceDialog()
    {
        //if we haven't gotten our results yet
        if (phaseIndex < 4)
        {
            //go to the next line
            dialogueIndex++;
            SetDialogueText();
            //if we're on the last line of dialogue
            if (dialogueIndex == currentDialogue.Count - 1)
            {
                //show the choices
                SetupChoices();
            }
        }
        //if we've seen our results
        else
        {
            //go to the last scene
            SceneManager.LoadScene("Start");
        }
    }

    void SetupChoices()
    {
        //turn off the next button and turn on the choice buttons
        nextButton.SetActive(false);
        choiceOne.SetActive(true);
        choiceTwo.SetActive(true);
    }


}
