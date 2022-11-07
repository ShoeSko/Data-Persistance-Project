using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public TMP_InputField nameInput;
    public TextMeshProUGUI highScoreDisplay;

    private void Start()
    {
        string score = PlayerPrefs.GetInt("HighScore").ToString();
        string bName = PlayerPrefs.GetString("BestPlayer");

        highScoreDisplay.text = "High Score: " + bName + " " + score;
    }

    private void Update()
    {
        PlayerPrefs.SetString("CurrentPlayer", nameInput.text);
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
}
