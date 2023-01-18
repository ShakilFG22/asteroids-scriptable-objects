using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CountValue : MonoBehaviour
{

    private Label  counterLabel;
    private Button counterButtonPlus;
    private Button counterButtonMinus;

    private int count = 0;
    [SerializeField] private MySO _mySo;
    
    
    private void OnEnable()
    {
        VisualElement rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        counterLabel        = rootVisualElement.Q<Label >("MinST"   );
        counterButtonPlus   = rootVisualElement.Q<Button>("IncMinST");
        counterButtonMinus  = rootVisualElement.Q<Button>("DecMinST");
        
        
        counterButtonPlus. RegisterCallback<ClickEvent>(ev => IncrementCounter());
        counterButtonMinus.RegisterCallback<ClickEvent>(ev => DecrementCounter());
        
    }

    private void IncrementCounter()
    {
        count++;
        counterLabel.text = $"{count}";
        _mySo._minSpawnTime = count;
        if (count >= 10)
        {
            count = 10;
            counterLabel.text = $"{count}";
            _mySo._minSpawnTime = count;
        }
    }

    private void DecrementCounter()
    {
        count--;
        counterLabel.text = $"{count}";
        _mySo._minSpawnTime = count;
        if (count <= -1)
        {
            count = 0;
            counterLabel.text = $"{count}";
            _mySo._minSpawnTime = count;
        }
    }
}
