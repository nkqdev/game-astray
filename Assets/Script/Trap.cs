using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject player;
    public GameObject GameLosePanel;
    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameLosePanel.SetActive(true);
            player.GetComponent<Movement>().enabled = false;
        }
    }
}
