using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedButtonPiston4 : MonoBehaviour
{
    public GameObject finishedButton;
    public GameObject cancelButton;
    public GameObject pistonScrewSnapZone4;
    public GameObject pistonCaseSnapZone4;
    public GameObject piston4;
    public GameObject pistonCaseInstructions;

    public GameObject[] piston4Parts;
    // Start is called before the first frame update
    void Start()
    {
        finishedButton.SetActive(false);
        cancelButton.SetActive(false);
        piston4.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (pistonCaseSnapZone4.activeInHierarchy && pistonCaseSnapZone4.activeInHierarchy)
        {
            finishedButton.SetActive(true);
        }
    }

    public void AssemblyButton()
    {
        foreach (GameObject c in piston4Parts)
        {
            c.gameObject.SetActive(false);
            piston4.SetActive(true);
            finishedButton.SetActive(false);
            cancelButton.SetActive(true);
            pistonCaseInstructions.SetActive(false);
        }

    }

    public void CancelButton()
    {
        foreach (GameObject c in piston4Parts)
        {
            c.gameObject.SetActive(true);
            piston4.SetActive(false);
            finishedButton.SetActive(true);
            cancelButton.SetActive(false);
        }
    }
}
