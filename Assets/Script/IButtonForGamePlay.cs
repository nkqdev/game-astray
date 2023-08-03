using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IButtonForGamePlay : MonoBehaviour
{
    public GameObject interactButton;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactButton.SetActive(false);
        }
    }
}
