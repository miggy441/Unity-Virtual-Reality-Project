using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCycle : MonoBehaviour
{
    [SerializeField] private Material skybox;
    private float elapsedTime = 0f;
    private float timeScale = 0.75f;
    private static readonly int Rotation = Shader.PropertyToID("_Rotation");
    //private static readonly int Exposure = Shader.PropertyToID("_Exposure");
    
    void Update()
    {
        elapsedTime += Time.deltaTime;
        skybox.SetFloat(Rotation, elapsedTime * timeScale);
        //skybox.SetFloat(Exposure, Mathf.Clamp(Mathf.Sin(elapsedTime), 0.15f, 1f));
    }
}
