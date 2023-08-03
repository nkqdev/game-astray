using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public GameObject player;
    public GameObject GameLosePanel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameLosePanel.SetActive(true);
            player.GetComponent<Movement>().enabled = false;
        }
    }
}
