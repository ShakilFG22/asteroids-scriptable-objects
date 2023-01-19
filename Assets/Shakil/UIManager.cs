using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject uiDocument;

    private void Start()
    {
        uiDocument.SetActive(false);
    }
    
    void Update()
    {
        if (!uiDocument.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("ESC1");
            uiDocument.SetActive(true);
            Time.timeScale = 0;
        }
        else if ( uiDocument.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            uiDocument.SetActive(false);
            Debug.Log("ESC2");
            Time.timeScale = 1;
        }
    }
}
