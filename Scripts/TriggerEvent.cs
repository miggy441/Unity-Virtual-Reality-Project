using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]

public class TriggerEvent : MonoBehaviour
{
    public string targetTag;

    public UnityEvent OnTriggerIn;
    public UnityEvent OnTriggerOut;
    //public UnityEvent<GameObject> OnTriggerWithGameObject;

    private bool isInside = false;

    private void Start()
    {

    }

    private void Update()
    {
        if (isInside == true)
        {
            OnTriggerIn?.Invoke();
        }
        else
        {
            OnTriggerOut?.Invoke();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == targetTag)
        {
            isInside = true;
            //OnTriggerIn?.Invoke();
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.tag == targetTag)
        {
            isInside = false;
            //OnTriggerOut?.Invoke();
        }
    }
}
