using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject GameLosePanel;
    public GameObject Enemy;
    public GameObject player;

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            GameLosePanel.SetActive(true);
            player.GetComponent<Movement>().enabled = false;
            Enemy.SetActive(false);
        }
            
    }
}
