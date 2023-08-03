using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueGameWin : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text dialogueText;
    public string[] dialogue;

    public GameObject interactButton;
    public GameObject yesButton;
    public GameObject noButton;
    public GameObject interactButton1;
    public GameObject GameWinPanel;
    public GameObject player;

    private int index;

    public float wordSpeed;
    public bool playerIsClose;
    public bool IsClick;

    public void resetText()
    {
        dialogueText.text = "";
        index = 0;
        dialoguePanel.SetActive(false);
    }

    IEnumerator Typing()
    {
        foreach (char letter in dialogue[index].ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(wordSpeed);

        }
    }



    public void gameWinPanel()
    {
        GameWinPanel.SetActive(true);
        player.GetComponent<Movement>().enabled = false;
    }

    public void startChat()
    {
        IsClick = true;

        if (IsClick == true && playerIsClose)
        {
            if (dialoguePanel.activeInHierarchy)
            {
                resetText();
                yesButton.SetActive(true);
                noButton.SetActive(true);
            }
            else
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }
    }


    public void endChat()
    {
        dialoguePanel.SetActive(false);
        interactButton1.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
            interactButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactButton.SetActive(false);
            playerIsClose = false;
            resetText();
        }
    }
}
