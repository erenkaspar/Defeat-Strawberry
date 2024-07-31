using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameSettingsManager : MonoBehaviour
{
    bool resetScoreActive = true;
    bool mainMenuActive = true;
    public GameObject resetScoreYesButton;
    public GameObject resetScoreNoButton;
    public GameObject mainMenuYesButton;
    public GameObject mainMenuNoButton;
    public GameManager gameManager;
    
    void Start() {
        resetScoreActive = true;
        mainMenuActive = true;
    }

    public void ResetScoreButton() {
        if(resetScoreActive) {
            resetScoreYesButton.SetActive(true);
            resetScoreNoButton.SetActive(true);
            resetScoreActive = false;
        } else {
            resetScoreYesButton.SetActive(false);
            resetScoreNoButton.SetActive(false);
            resetScoreActive = true;
        }
    }
    public void ResetScoreYesButton() {
        gameManager.gameScore = 0;
        PlayerPrefs.SetInt("score", 0);
        PlayerPrefs.Save();
        gameManager.UpdateScoreUI();
    }
    public void ResetScoreNoButton() {
        resetScoreYesButton.SetActive(false);
        resetScoreNoButton.SetActive(false);
        resetScoreActive = true;
    }


    public void MainMenuButton() {
        if(mainMenuActive) {
            mainMenuYesButton.SetActive(true);
            mainMenuNoButton.SetActive(true);
            mainMenuActive = false;
        } else {
            mainMenuYesButton.SetActive(false);
            mainMenuNoButton.SetActive(false);
            mainMenuActive = true;
        }
    }
    public void MainMenuYesButton() {
        PlayerPrefs.Save();
        SceneManager.LoadScene(0);
    }
    public void MainMenuNoButton() {
        mainMenuYesButton.SetActive(false);
        mainMenuNoButton.SetActive(false);
        mainMenuActive = true;
    }
}
