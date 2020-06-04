using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float screenChangeDelay = 3f;

    int currentSceneIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        if (currentSceneIndex == 0)
        {
            StartCoroutine(StartScreenDelay());
        }
    }

    IEnumerator StartScreenDelay()
    {
        yield return new WaitForSeconds(screenChangeDelay);
        LoadNextScene();
    }
    
    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("Game Over");
    }
}
