using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedButtonPiston3 : MonoBehaviour
{
    public GameObject finishedButton;
    public GameObject cancelButton;
    public GameObject pistonScrewSnapZone3;
    public GameObject pistonCaseSnapZone3;
    public GameObject piston3;
    public GameObject pistonCaseInstructions;

    public GameObject[] piston3Parts;
    // Start is called before the first frame update
    void Start()
    {
        finishedButton.SetActive(false);
        cancelButton.SetActive(false);
        piston3.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (pistonCaseSnapZone3.activeInHierarchy && pistonCaseSnapZone3.activeInHierarchy)
        {
            finishedButton.SetActive(true);
        }
    }

    public void AssemblyButton()
    {
        foreach (GameObject c in piston3Parts)
        {
            c.gameObject.SetActive(false);
            piston3.SetActive(true);
            finishedButton.SetActive(false);
            cancelButton.SetActive(true);
            pistonCaseInstructions.SetActive(false);
        }

    }

    public void CancelButton()
    {
        foreach (GameObject c in piston3Parts)
        {
            c.gameObject.SetActive(true);
            piston3.SetActive(false);
            finishedButton.SetActive(true);
            cancelButton.SetActive(false);
        }
    }
}
