using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
    private static int MenuIndex = 0;
    private static int PlayIndex = 1;
    private static int QuitIndex = 2;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void PlayGame()
    {
        SceneManager.LoadScene(PlayIndex);
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(QuitIndex);
    }

    public void MenuScene()
    {
        SceneManager.LoadScene(MenuIndex);
    }
}
