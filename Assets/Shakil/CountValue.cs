using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;
using Debug = UnityEngine.Debug;

public class CountValue : MonoBehaviour
{


    private Label [] counterLabels = new Label [10];
    private Button[] counterButton = new Button[20];

    private float[] count = new float[10];
    [SerializeField] private MySO _mySo;
    

    private void OnEnable()
    {
        VisualElement rootVisualElement = GetComponent<UIDocument>().rootVisualElement;

        counterLabels[0] = rootVisualElement.Q<Label>("MinST");
        counterLabels[1] = rootVisualElement.Q<Label>("MaxST");
        counterLabels[2] = rootVisualElement.Q<Label>("MinAm");
        counterLabels[3] = rootVisualElement.Q<Label>("MaxAm");
        counterLabels[4] = rootVisualElement.Q<Label>("MinFor");
        counterLabels[5] = rootVisualElement.Q<Label>("MaxFor");
        // counterLabels[6] = rootVisualElement.Q<Label>("MinSiz");
        counterLabels[7] = rootVisualElement.Q<Label>("MaxSiz");
        // counterLabels[8] = rootVisualElement.Q<Label>("MaxST");
        counterLabels[9] = rootVisualElement.Q<Label>("MaxTor");
        
        counterButton[ 0] = rootVisualElement.Q<Button>("IncMinST");
        counterButton[ 1] = rootVisualElement.Q<Button>("DecMinST");
        counterButton[ 2] = rootVisualElement.Q<Button>("IncMaxST");
        counterButton[ 3] = rootVisualElement.Q<Button>("DecMaxST");
        counterButton[ 4] = rootVisualElement.Q<Button>("IncMinAm");
        counterButton[ 5] = rootVisualElement.Q<Button>("DecMinAm");
        counterButton[ 6] = rootVisualElement.Q<Button>("IncMaxAm");
        counterButton[ 7] = rootVisualElement.Q<Button>("DecMaxAm");
        counterButton[ 8] = rootVisualElement.Q<Button>("IncMinFor");
        counterButton[ 9] = rootVisualElement.Q<Button>("DecMinFor");
        counterButton[10] = rootVisualElement.Q<Button>("IncMaxFor");
        counterButton[11] = rootVisualElement.Q<Button>("DecMaxFor");
        // counterButton[12] = rootVisualElement.Q<Button>("IncMinSiz");
        // counterButton[13] = rootVisualElement.Q<Button>("DecMinSiz");
        counterButton[14] = rootVisualElement.Q<Button>("IncMaxSiz");
        counterButton[15] = rootVisualElement.Q<Button>("DecMaxSiz");
        // counterButton[16] = rootVisualElement.Q<Button>("DecMinST");
        // counterButton[17] = rootVisualElement.Q<Button>("DecMinST");
        counterButton[18] = rootVisualElement.Q<Button>("IncMaxTor");
        counterButton[19] = rootVisualElement.Q<Button>("DecMaxTor");
        
        
        counterButton[ 0].RegisterCallback<ClickEvent>(ev => IncrementCounter(0));
        counterButton[ 1].RegisterCallback<ClickEvent>(ev => DecrementCounter(0));
        counterButton[ 2].RegisterCallback<ClickEvent>(ev => IncrementCounter(1));
        counterButton[ 3].RegisterCallback<ClickEvent>(ev => DecrementCounter(1));
        counterButton[ 4].RegisterCallback<ClickEvent>(ev => IncrementCounter(2));
        counterButton[ 5].RegisterCallback<ClickEvent>(ev => DecrementCounter(2));
        counterButton[ 6].RegisterCallback<ClickEvent>(ev => IncrementCounter(3));
        counterButton[ 7].RegisterCallback<ClickEvent>(ev => DecrementCounter(3));
        counterButton[ 8].RegisterCallback<ClickEvent>(ev => IncrementCounter(4));
        counterButton[ 9].RegisterCallback<ClickEvent>(ev => DecrementCounter(4));
        counterButton[10].RegisterCallback<ClickEvent>(ev => IncrementCounter(5));
        counterButton[11].RegisterCallback<ClickEvent>(ev => DecrementCounter(5));
        // counterButton[12].RegisterCallback<ClickEvent>(ev => IncrementCounter(6));
        // counterButton[13].RegisterCallback<ClickEvent>(ev => DecrementCounter(6));
        counterButton[14].RegisterCallback<ClickEvent>(ev => IncrementCounter(7));
        counterButton[15].RegisterCallback<ClickEvent>(ev => DecrementCounter(7));
        // counterButton[16].RegisterCallback<ClickEvent>(ev => DecrementCounter(8));
        // counterButton[17].RegisterCallback<ClickEvent>(ev => IncrementCounter(8));
        counterButton[18].RegisterCallback<ClickEvent>(ev => IncrementCounter(9));
        counterButton[19].RegisterCallback<ClickEvent>(ev => DecrementCounter(9));
    }
    
    private void IncrementCounter(int value)
    {
        // switch (value)
        // {
        //     case 6:
        //         count[(int)value] += 0.2f;
        //         counterLabels[(int)value].text = $"{count[(int)value]}";
        //         _mySo._minSize = count[value];
        //         LimitIncrement(value);
        //         break;
        //     case 8:
        //         count[(int)value] += 0.1f;
        //         counterLabels[(int)value].text = $"{count[(int)value]}";
        //         _mySo._minTorque = count[value];
        //         LimitIncrement(value);
        //         break;
        //     case 9:
        //         count[(int)value] += 0.1f;
        //         counterLabels[(int)value].text = $"{count[(int)value]}";
        //         _mySo._maxTorque = count[value];
        //         LimitIncrement(value);
        //         break;
        // }

        if (value != 6 || value != 8)
        {
            count[(int)value]++;
            counterLabels[(int)value].text = $"{count[(int)value]}";
            switch (value)
            {
                case 0: _mySo._minSpawnTime = (int)count[(int)value]; LimitIncrement((int)value); break;
                case 1: _mySo._maxSpawnTime = (int)count[(int)value]; LimitIncrement((int)value); break;
                case 2: _mySo._minAmount    = (int)count[(int)value]; LimitIncrement((int)value); break;
                case 3: _mySo._maxAmount    = (int)count[(int)value]; LimitIncrement((int)value); break;
                case 4: _mySo._minForce     = (int)count[(int)value]; LimitIncrement((int)value); break;
                case 5: _mySo._maxForce     = (int)count[(int)value]; LimitIncrement((int)value); break;
             // case 6: _mySo._minSize      = (int)count[(int)value]; LimitIncrement((int)value); break;
                case 7: _mySo._maxSize      = (int)count[(int)value]; LimitIncrement((int)value); break;
             // case 8: _mySo._minTorque    = (int)count[(int)value]; LimitIncrement((int)value); break;
                case 9: _mySo._maxTorque    = (int)count[(int)value]; LimitIncrement((int)value); break;
                default: Debug.Log("HAHA!");
                    break;
            }
        }
    }

    private void DecrementCounter(int value)
    {
        // switch (value)
        // {
        //     case 6:
        //         count[(int)value] -= 0.2f;
        //         counterLabels[(int)value].text = $"{count[(int)value]}";
        //         _mySo._minSize = count[value];
        //         LimitDecrement(value);
        //         break;
        //     case 8:
        //         count[(int)value] -= 0.1f;
        //         counterLabels[(int)value].text = $"{count[(int)value]}";
        //         _mySo._minTorque = count[value];
        //         LimitDecrement(value);
        //         break;
        //     case 9:
        //         count[(int)value] -= 0.1f;
        //         counterLabels[(int)value].text = $"{count[(int)value]}";
        //         _mySo._maxTorque = count[value];
        //         LimitDecrement(value);
        //         break;
        // }
        
        if (value != 6 || value != 8)
        {
            count[(int)value]--;
            counterLabels[(int)value].text = $"{count[(int)value]}";
            switch (value)
            {
                case 0: _mySo._minSpawnTime = (int)count[(int)value]; LimitDecrement((int)value); break;
                case 1: _mySo._maxSpawnTime = (int)count[(int)value]; LimitDecrement((int)value); break;
                case 2: _mySo._minAmount    = (int)count[(int)value]; LimitDecrement((int)value); break;
                case 3: _mySo._maxAmount    = (int)count[(int)value]; LimitDecrement((int)value); break;
                case 4: _mySo._minForce     = (int)count[(int)value]; LimitDecrement((int)value); break;
                case 5: _mySo._maxForce     = (int)count[(int)value]; LimitDecrement((int)value); break;
                // case 6: _mySo._minSize      = (int)count[(int)value]; LimitDecrement((int)value); break;
                case 7: _mySo._maxSize      = (int)count[(int)value]; LimitDecrement((int)value); break;
                // case 8: _mySo._minTorque    = (int)count[(int)value]; LimitDecrement((int)value); break;
                case 9: _mySo._maxTorque    = (int)count[(int)value]; LimitDecrement((int)value); break;
                default: Debug.Log("HAHA!");
                    break;
            }
        }
    }
    private void LimitIncrement(int value)
    {
        if (count[value] >= 10)
        {
            count[value] = 10;
            counterLabels[value].text = $"{count[value]}";
            switch (value)
            {
                case 0: _mySo._minSpawnTime = count[value]; break;
                case 1: _mySo._maxSpawnTime = count[value]; break;
                case 2: _mySo._minAmount    = (int)count[value]; break;
                case 3: _mySo._maxAmount    = (int)count[value]; break;
                case 4: _mySo._minForce     = count[value]; break;
                case 5: _mySo._maxForce     = count[value]; break;
                case 6: _mySo._minSize      = count[value]; break; //Float
                case 7: _mySo._maxSize      = count[value]; break;
                case 8: _mySo._minTorque    = count[value]; break; //Float
                case 9: _mySo._maxTorque    = count[value]; break; //Float
            }
        }
    }
    private void LimitDecrement(int value)
    {
        if (count[value] <= -1)
        {
            count[value] = 0;
            counterLabels[value].text = $"{count[value]}";
            switch (value)
            {
                case 0: _mySo._minSpawnTime = count[value]; break;
                case 1: _mySo._maxSpawnTime = count[value]; break;
                case 2: _mySo._minAmount    = (int)count[value]; break;
                case 3: _mySo._maxAmount    = (int)count[value]; break;
                case 4: _mySo._minForce     = count[value]; break;
                case 5: _mySo._maxForce     = count[value]; break;
                case 6: _mySo._minSize      = count[value]; break; //Float
                case 7: _mySo._maxSize      = count[value]; break;
                case 8: _mySo._minTorque    = count[value]; break; //Float
                case 9: _mySo._maxTorque    = count[value]; break; //Float
            }
        }
    }
}
