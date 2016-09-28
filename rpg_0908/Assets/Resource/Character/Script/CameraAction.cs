using UnityEngine;
using System.Collections;

public class CameraAction : MonoBehaviour 
{
    public GameObject Camera;

    void Start()
    {
        this.transform.position = Camera.transform.position;
    }

    void Update()
    {
        this.transform.position = Camera.transform.position;
    }
}
