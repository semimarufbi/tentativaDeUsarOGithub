using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WindowManager : MonoBehaviour
{
    #region Singleton
    private void Awake()
    {
        instance = this;
    }
    #endregion
    static public WindowManager instance;
    [SerializeField]
    GameObject gameOverWindown;
    [SerializeField]
    TextMeshProUGUI scoreText;
    [SerializeField]
    TextMeshProUGUI finalScoreText;
    [SerializeField]
    TextMeshProUGUI recordText;

    public TextMeshProUGUI ScoreText { get => scoreText;}
    public TextMeshProUGUI FinalScoreText { get => finalScoreText;}
    public TextMeshProUGUI RecordText { get => recordText;}
    public GameObject GameOverWindown { get => gameOverWindown;}

    public void Menu() 
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1.0f;
    }
}
