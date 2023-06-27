using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public GameObject mainMenuPanel;
    

    // Start is called before the first frame update
    void Start()
    {
        mainMenuPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void StartButtonPressed()
    {
        SceneManager.LoadScene("EngineAssembly");
        Time.timeScale = 1;
    }

    public void QuitButtonPressed()
    {
        Application.Quit();
    }
}
