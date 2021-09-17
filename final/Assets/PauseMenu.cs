using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIspause = false;
    // Start is called before the first frame update
    public GameObject pauseMenuUI;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIspause)
            {
                Resume();
                
            }
            else
            {
                Pause();
                
            }
            
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIspause = false;
        Cursor.visible = false;
        
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIspause = true;
        Cursor.visible = true;
        
    }
    public void loadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("menu");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
