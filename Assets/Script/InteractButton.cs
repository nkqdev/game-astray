using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractButton : MonoBehaviour
{
    public GameObject interactButton;
    public GameObject treasure;
    public GameObject portal;

    public void Treasure()
    {
        treasure.SetActive(false);
        portal.SetActive(true);
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
