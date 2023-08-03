using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public GameObject dialoguePanel;
    public Text dialogueText;
    public string[] dialogue;
    public GameObject countButton;
    public GameObject interactButton;
    public GameObject interactButton1;

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

    public void NextLine()
    {
        countButton.SetActive(true);
        if (index < dialogue.Length)
        {
            index++;
            dialogueText.text = "";
            StartCoroutine(Typing());
        }
        else
        {
            endChat();
        }
    }

    public void startChat()
    {
        IsClick = true;
        interactButton.SetActive(false);
        interactButton1.SetActive(true);
        if (IsClick == true && playerIsClose)
        {
            if (dialoguePanel.activeInHierarchy)
            {
                resetText();
            }
            else
            {
                dialoguePanel.SetActive(true);
                StartCoroutine(Typing());
            }
        }
        if (dialogueText.text == dialogue[index])
        {
            countButton.SetActive(true);
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
