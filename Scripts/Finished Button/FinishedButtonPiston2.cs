using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedButtonPiston2 : MonoBehaviour
{
    public GameObject finishedButton;
    public GameObject cancelButton;
    public GameObject pistonScrewSnapZone2;
    public GameObject pistonCaseSnapZone2;
    public GameObject piston2;
    public GameObject pistonCaseInstructions;

    public GameObject[] piston2Parts;
    // Start is called before the first frame update
    void Start()
    {
        finishedButton.SetActive(false);
        cancelButton.SetActive(false);
        piston2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pistonCaseSnapZone2.activeInHierarchy && pistonCaseSnapZone2.activeInHierarchy)
        {
            finishedButton.SetActive(true);
        }
    }

    public void AssemblyButton()
    {
        foreach (GameObject c in piston2Parts)
        {
            c.gameObject.SetActive(false);
            piston2.SetActive(true);
            finishedButton.SetActive(false);
            cancelButton.SetActive(true);
            pistonCaseInstructions.SetActive(false);
        }

    }

    public void CancelButton()
    {
        foreach (GameObject c in piston2Parts)
        {
            c.gameObject.SetActive(true);
            piston2.SetActive(false);
            finishedButton.SetActive(true);
            cancelButton.SetActive(false);
        }
    }
}
