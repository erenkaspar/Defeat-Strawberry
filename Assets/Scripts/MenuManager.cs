using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{

    public Text scoreText;
    public Text leaderboardScoreText;
    public GameObject mainPanel;
    public GameObject leaderboardPanel;
    public GameObject settingsPanel;
    public GameObject quitPanel;
    public GameObject tableUnder;
    public GameObject sendNamePanel;

    //PlayFab
    public PlayFabManager playFabManager;

    void Start() {
        EverythingOff();
        mainPanel.SetActive(true);
        scoreText.text = PlayerPrefs.GetInt("score").ToString();
        leaderboardScoreText.text = PlayerPrefs.GetInt("score").ToString();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (mainPanel.activeSelf) {
                EverythingOff();
                quitPanel.SetActive(true);
            } else {
                EverythingOff();
                mainPanel.SetActive(true);
            }
        }
    }

    public void PlayButton() {
        SceneManager.LoadScene(1);
    }

    public void LeaderboardButton() {
        EverythingOff();
        leaderboardPanel.SetActive(true);
    }
    public void SaveScoreButton() {
        tableUnder.SetActive(false);
        sendNamePanel.SetActive(true);
    }
    public void OkeyButton() {
        playFabManager.SendLeaderboard(PlayerPrefs.GetInt("score"));
        playFabManager.SubmitNameButton();
        playFabManager.GetLeaderboard();
        tableUnder.SetActive(true);
        sendNamePanel.SetActive(false);
    }
    public void CancelButton() {
        playFabManager.GetLeaderboard();
        tableUnder.SetActive(true);
        sendNamePanel.SetActive(false);
    }

    public void SettingsButton() {
        EverythingOff();
        settingsPanel.SetActive(true);
    }

    public void QuitButton() {
        EverythingOff();
        quitPanel.SetActive(true);
    }
    public void QuitYesButton() {
        Application.Quit();
    }

    public void EverythingOff() {
        mainPanel.SetActive(false);
        leaderboardPanel.SetActive(false);
        settingsPanel.SetActive(false);
        quitPanel.SetActive(false);
    }
}
