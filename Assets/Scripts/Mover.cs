using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    string horizontalAxis = "Horizontal";
    string verticalAxis = "Vertical";
    float speed = 5f;
    

    void Update() {
        Move();
    }

    void Move() {
        float xValue = Input.GetAxis(horizontalAxis);
        float zValue = Input.GetAxis(verticalAxis);
        float yValue = 0f;
        Vector3 pos = new Vector3(xValue, yValue, zValue).normalized;
        transform.Translate(pos * Time.deltaTime * speed);
    }
}
