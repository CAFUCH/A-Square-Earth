using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject HelpP, OverP;

    public void Exit() {

        HelpP.SetActive(false);
    }

    public void ReTry() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Over() {

        OverP.SetActive(true);
    }
}
