using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishedButtonAssembly : MonoBehaviour
{

    public GameObject finishedButton;
    public GameObject cancelButton;
    public GameObject pistonScrewSnapZone1;
    public GameObject pistonCaseSnapZone1;
    public GameObject piston1;
    public GameObject pistonCaseInstructions;

    public GameObject[] piston1Parts;
    // Start is called before the first frame update
    void Start()
    {
        finishedButton.SetActive(false);
        cancelButton.SetActive(false);
        piston1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pistonCaseSnapZone1.activeInHierarchy && pistonCaseSnapZone1.activeInHierarchy)
        {
            finishedButton.SetActive(true);
        }
    }

    public void AssemblyButton()
    {
        foreach (GameObject c in piston1Parts)
        {
            c.gameObject.SetActive(false);
            piston1.SetActive(true);
            finishedButton.SetActive(false);
            cancelButton.SetActive(true);
            pistonCaseInstructions.SetActive(false);
        }

    }

    public void CancelButton()
    {
        foreach (GameObject c in piston1Parts)
        {
            c.gameObject.SetActive(true);
            piston1.SetActive(false);
            finishedButton.SetActive(true);
            cancelButton.SetActive(false);
        }
    }
}
