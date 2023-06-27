using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SequenceMechanism : MonoBehaviour
{
    public GameObject[] requirement;
    public GameObject[] orRequirement;
    private bool requirement1Fulfilled = false;
    private bool requirement2Fulfilled = false;

    public GameObject[] requirementFalse;
    public GameObject[] orRequirementFalse;
    private bool requirementFalse1Fulfilled = false;
    private bool requirementFalse2Fulfilled = false;

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

        foreach (GameObject go in orRequirement)
        {
            if (go.gameObject.activeInHierarchy)
            {
                requirement2Fulfilled = true;
            }
            else
            {
                requirement2Fulfilled = false;
                break;
            }
        }

/*        if (requirement1Fulfilled == true || requirement2Fulfilled == true)
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
            foreach (GameObject go in activateThis)
            {
                go.gameObject.SetActive(false);
            }
            foreach (GameObject go in deactivateThis)
            {
                go.gameObject.SetActive(true);
            }
        }*/
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

        foreach (GameObject go in orRequirementFalse)
        {
            if (go.gameObject.activeInHierarchy == false)
            {
                requirementFalse2Fulfilled = true;
            }
            else
            {
                requirementFalse2Fulfilled = false;
                break;
            }
        }

/*        if (requirementFalse1Fulfilled == true || requirementFalse2Fulfilled == true)
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
            foreach (GameObject go in activateThis)
            {
                go.gameObject.SetActive(false);
            }
            foreach (GameObject go in deactivateThis)
            {
                go.gameObject.SetActive(true);
            }
        }*/
    }

    public void ExecuteAction()
    {
        if (requirement1Fulfilled == true || requirement2Fulfilled == true)
        {
            if (requirementFalse1Fulfilled == true || requirementFalse2Fulfilled == true)
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
                foreach (GameObject go in activateThis)
                {
                    go.gameObject.SetActive(false);
                }
                foreach (GameObject go in deactivateThis)
                {
                    go.gameObject.SetActive(true);
                }
            }
        }
        else
        {
            foreach (GameObject go in activateThis)
            {
                go.gameObject.SetActive(false);
            }
            foreach (GameObject go in deactivateThis)
            {
                go.gameObject.SetActive(true);
            }
        }
    }
}
