using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valueinyourhead : MonoBehaviour
{
    public Camera _camera;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void LateUpdate()
    {
        transform.LookAt(transform.position + _camera.transform.rotation * Vector3.forward, _camera.transform.rotation * Vector3.up);
    }
}
