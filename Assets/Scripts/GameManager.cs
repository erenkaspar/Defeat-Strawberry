using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int gameScore;
    public Text scoreText;
    public GameObject settingsPanel;

    void Start() {
        gameScore = PlayerPrefs.GetInt("score");

        UpdateScoreUI();
    }

    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            SettingsPanelButton();
        }
    }

    public void AddScore() {
        gameScore++;
        PlayerPrefs.SetInt("score", gameScore);
        PlayerPrefs.Save();
        UpdateScoreUI();
    }

    public void UpdateScoreUI() {
        scoreText.text = gameScore.ToString();
    }

    public void SettingsPanelButton() {
        if(settingsPanel.activeSelf) {
            settingsPanel.SetActive(false);
        } else {
            settingsPanel.SetActive(true);
        }
    }
}
