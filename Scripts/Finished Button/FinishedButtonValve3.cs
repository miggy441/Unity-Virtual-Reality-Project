using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedButtonValve3 : MonoBehaviour
{
    public GameObject finishedButton;
    public GameObject cancelButton;
    public GameObject pistonSpringSnapZone1;
    public GameObject pistonCapSnapZone1;
    public GameObject valve1;
    public GameObject valveCapInstruction;

    public GameObject[] valve1Parts;
    // Start is called before the first frame update
    void Start()
    {
        finishedButton.SetActive(false);
        cancelButton.SetActive(false);
        valve1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (pistonCapSnapZone1.activeInHierarchy && pistonSpringSnapZone1.activeInHierarchy)
        {
            finishedButton.SetActive(true);
        }
        else
        {
            finishedButton.SetActive(false);

        }
    }

    public void AssemblyButton()
    {
        foreach (GameObject c in valve1Parts)
        {
            c.gameObject.SetActive(false);
            valve1.SetActive(true);
            finishedButton.SetActive(false);
            cancelButton.SetActive(true);
            valveCapInstruction.SetActive(false);
        }

    }

    public void CancelButton()
    {
        foreach (GameObject c in valve1Parts)
        {
            c.gameObject.SetActive(true);
            valve1.SetActive(false);
            finishedButton.SetActive(true);
            cancelButton.SetActive(false);
        }
    }
}
