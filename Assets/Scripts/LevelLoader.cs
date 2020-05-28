using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float menuDelay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartScreenDelay());
    }

    IEnumerator StartScreenDelay()
    {
        yield return new WaitForSeconds(menuDelay);
        LoadMainMenu();
    }
    
    private void LoadMainMenu()
    {
        SceneManager.LoadScene(1);
    }
}
