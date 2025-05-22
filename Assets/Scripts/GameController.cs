using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public GameObject GameOverPanel;
    public GameObject TapToStart;
    public GameObject ScoreText;
    public GameObject PauseImage;
    bool isPause = false;
    public GameObject completelvlUI;
    public void CompleteLevel()
    {
        completelvlUI.SetActive(true);

    }
    private void Start()
    {
        GameOverPanel.SetActive(false);
        TapToStart.SetActive(true);
        PauseTheGame();
        ScoreText.SetActive(false);
        PauseImage.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
    }
    public void GameOver()
    {
        ScoreText.SetActive(false);
        PauseImage.SetActive(false);
        GameOverPanel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void PauseTheGame()
    {
        Time.timeScale = 0f;
    }
    public void StartGame()
    {
        ScoreText.SetActive(true);
        PauseImage.SetActive(true);
        Time.timeScale = 1f;
        TapToStart.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
    public void PauseGame()
    {
        if (isPause)
        {
            Time.timeScale = 1;
            isPause = false;
        }
        else
        {
            Time.timeScale = 0;
            isPause = true;
        }
    }
}
