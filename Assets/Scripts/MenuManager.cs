using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public InputField inputField;
    public Text highScoreText;

    private void Start()
    {
        DataManager.Instance.LoadColor();
        highScoreText.text = $"Best Score: {DataManager.Instance.highScoreName} : {DataManager.Instance.highScore}";
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SetName(string name)
    {
        DataManager.Instance.playerName = inputField.text;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
