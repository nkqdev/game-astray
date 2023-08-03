using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasure1 : MonoBehaviour
{
    public GameObject interactButton;
    public GameObject treasure;
    public GameObject nextTreasure;

    public void PickTreasure()
    {
        treasure.SetActive(false);
        nextTreasure.SetActive(true);
    }

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
