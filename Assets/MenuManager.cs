using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TextMeshProUGUI highScoreDisplay;

    private void Start()
    {
        UpdateHighScore();
    }

    private void Update()
    {
        PlayerPrefs.SetString("CurrentPlayer", nameInput.text);
        PlayerPrefs.Save();
    }


    public void StartGame()
    {
        //Load Game Scene (Consistent as 1, only 2 scenes to ever exist)
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void UpdateHighScore()
    {
        string score = PlayerPrefs.GetInt("HighestScore").ToString();
        string bName = PlayerPrefs.GetString("BestPlayer");

        highScoreDisplay.text = "High Score: " + bName + " " + score;
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("HighestScore", 0);
        PlayerPrefs.SetString("BestPlayer", "Ayame");

        UpdateHighScore();
    }
    
}
