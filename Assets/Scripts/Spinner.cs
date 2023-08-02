using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    float xValue = 0f;
    float yValue = 0.5f;
    float zValue = 0f;
    [SerializeField]float speed = 2f;
    Vector3 rot;
    void Start()
    {
        rot=new Vector3(xValue,yValue,zValue);
    }

    void Update()
    {
        transform.Rotate(rot*speed);
    }
}
