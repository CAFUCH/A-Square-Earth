using Microsoft.Win32.SafeHandles;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    Player player;

    public int timberCnt, meatCnt = 0;
    [SerializeField] private TextMeshProUGUI timberTxt, meatTxt;
    [SerializeField] private Slider hpSlider, engSlider;

    private void Awake() {
        
        if (instance == null)
            instance = this;
        else
            Destroy(instance);

        player = GameObject.Find("Player").GetComponent<Player>();
    }

    private void Start() {
        
        hpSlider.maxValue = player.MaxHp;
        engSlider.maxValue = player.MaxEng;
    }

    private void Update() {
        
        timberTxt.text = timberCnt.ToString();
        meatTxt.text = meatCnt.ToString();

        hpSlider.value = player.Hp;
        engSlider.value = player.Eng;
    }
}
