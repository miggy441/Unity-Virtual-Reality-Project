using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInfo : MonoBehaviour
{

    public GameObject firstPanel;
    public GameObject secondPanel;
    public GameObject thirdPanel;
    public GameObject fourthPanel;
    //public GameObject picturePanel1;
    //public GameObject picturePanel2;
    //public GameObject backButton1;
    //public GameObject forwardButton1;

    public GameObject canvas;


    // Start is called before the first frame update
    void Start()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(false);
        thirdPanel.SetActive(false);
        fourthPanel.SetActive(false);
        //picturePanel1.SetActive(false);
        //picturePanel2.SetActive(false);
        //backButton1.SetActive(false);
        //forwardButton1.SetActive(false);

    }

    public void FirstButtonPressed()
    {
        firstPanel.SetActive(true);
        secondPanel.SetActive(false);
        thirdPanel.SetActive(false);
        fourthPanel.SetActive(false);
        //picturePanel1.SetActive(false);
        //picturePanel2.SetActive(false);
    }

    public void SecondButtonPressed()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(true);
        thirdPanel.SetActive(false);
        fourthPanel.SetActive(false);
    }

    public void ThirdButtonPressed()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(false);
        thirdPanel.SetActive(true);
        fourthPanel.SetActive(false);
    }

    public void FourthButtonPressed()
    {
        firstPanel.SetActive(false);
        secondPanel.SetActive(false);
        thirdPanel.SetActive(false);
        fourthPanel.SetActive(true);
    }

    public void BackButtonPressed()
    {
        canvas.SetActive(false);
    }

    


}
