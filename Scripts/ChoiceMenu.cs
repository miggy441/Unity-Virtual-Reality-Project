using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class ChoiceMenu : MonoBehaviour
{
    public GameObject choiceMenuPanel;
    public GameObject chassisAI;
    public GameObject engineAI;
    //AI = Assembly Instruction
    [SerializeField] private string titleSceneName;

    // Start is called before the first frame update
    void Start()
    {
        choiceMenuPanel.SetActive(false);
        chassisAI.SetActive(false);
        engineAI.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateEngineInstruction()
    {
        chassisAI.SetActive(true);
        engineAI.SetActive(false);
    }

    public void ActivateChassisInstruction()
    {
        engineAI.SetActive(true);
        chassisAI.SetActive(false);
    }

    public void ActivateChoiceMenu()
    {
        if (choiceMenuPanel.activeInHierarchy)
        {
            choiceMenuPanel.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            choiceMenuPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void RestartScene()
    {
        Scene thisScene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(thisScene.name);
        Time.timeScale = 1;
    }

    public void BackToTitleScreen()
    {
        SceneManager.LoadScene(titleSceneName);
        Time.timeScale = 1;
    }
}
