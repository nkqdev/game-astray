using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickSound : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private AudioSource audioSource;

    public void OnPointerDown(PointerEventData evenData)
    {
        audioSource.Play();
    }

}
