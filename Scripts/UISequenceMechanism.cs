using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISequenceMechanism : MonoBehaviour
{
    public GameObject[] requirement;
    private bool requirement1Fulfilled = false;

    public GameObject[] requirementFalse;
    private bool requirementFalse1Fulfilled = false;

    public GameObject[] activateThis;
    public GameObject[] deactivateThis;

    // Update is called once per frame
    void Update()
    {
        FulfillActiveCondition();
        FulfillInactiveCondition();
        ExecuteAction();
    }

    public void FulfillActiveCondition()
    {
        requirement1Fulfilled = true;
        foreach (GameObject go in requirement)
        {
            if (go.gameObject.activeInHierarchy)
            {
                requirement1Fulfilled = true;
            }
            else
            {
                requirement1Fulfilled = false;
                break;
            }
        }
    }

    public void FulfillInactiveCondition()
    {
        requirementFalse1Fulfilled = true;
        foreach (GameObject go in requirementFalse)
        {
            if (go.gameObject.activeInHierarchy == false)
            {
                requirementFalse1Fulfilled = true;
            }
            else
            {
                requirementFalse1Fulfilled = false;
                break;
            }
        }
    }

    public void ExecuteAction()
    {
        if (requirement1Fulfilled == true)
        {
            if (requirementFalse1Fulfilled == true)
            {
                foreach (GameObject go in activateThis)
                {
                    go.gameObject.SetActive(true);
                }
                foreach (GameObject go in deactivateThis)
                {
                    go.gameObject.SetActive(false);
                }
            }
            else
            {
            }
        }
        else
        {
        }
    }
}
