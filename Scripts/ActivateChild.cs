using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateChild : MonoBehaviour
{
    public GameObject go;

    // Start is called before the first frame update
    void Start()
    {
        go.transform.GetChild(0).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
