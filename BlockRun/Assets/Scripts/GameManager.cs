using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float retartDelay = 1f;

    public GameObject completeLevelUI;

    public AudioSource levelComplete;

    public Text levelText;

    private void Start()
    {
        levelText.text = SceneManager.GetActiveScene().buildIndex.ToString();
    }

    private void Update()
    {
        if (Input.GetKey("space"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    public void CompleteLevel()
    {
        levelComplete.Play();
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Invoke("Restart", retartDelay);
        }
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

