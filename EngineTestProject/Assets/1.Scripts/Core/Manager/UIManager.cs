using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public int timberCnt, meatCnt = 0;
    public TextMeshProUGUI timberTxt, meatTxt;

    private void Awake() {
        
        if (instance == null)
            instance = this;
        else
            Destroy(instance);
    }

    private void Update() {
        
        timberTxt.text = timberCnt.ToString();
        meatTxt.text = meatCnt.ToString();
    }
}
