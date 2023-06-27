using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishedButtonSuspension2 : MonoBehaviour
{
    public GameObject finishedButton;
    public GameObject cancelButton;
    public GameObject frontShockSnapZone1;
    public GameObject columnFixingSnapZone1;
    public GameObject suspension1;

    public GameObject[] suspension1Parts;
    // Start is called before the first frame update
    void Start()
    {
        finishedButton.SetActive(false);
        cancelButton.SetActive(false);
        suspension1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (frontShockSnapZone1.activeInHierarchy && columnFixingSnapZone1.activeInHierarchy)
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
        foreach (GameObject c in suspension1Parts)
        {
            c.gameObject.SetActive(false);
            suspension1.SetActive(true);
            finishedButton.SetActive(false);
            cancelButton.SetActive(true);
        }

    }

    public void CancelButton()
    {
        foreach (GameObject c in suspension1Parts)
        {
            c.gameObject.SetActive(true);
            suspension1.SetActive(false);
            finishedButton.SetActive(true);
            cancelButton.SetActive(false);
        }
    }
}
