using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;

    private void Start()
    {
        _gameObject.SetActive(false);
    }
    
    void Update()
    {
        if (!_gameObject.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("ESC1");
            _gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else if ( _gameObject.activeSelf && Input.GetKeyDown(KeyCode.Escape))
        {
            _gameObject.SetActive(false);
            Debug.Log("ESC2");
            Time.timeScale = 1;
        }
    }
}
