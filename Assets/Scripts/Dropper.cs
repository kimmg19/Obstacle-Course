using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Dropper : MonoBehaviour {
    float time;
    float timeToWait = 5f;

    private void Start() {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<Rigidbody>().useGravity =false;
    }

    private void Update() {
        time = Time.time;
        if (time >= timeToWait) {
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            gameObject.GetComponent<Rigidbody>().useGravity = true;

        }
    }
}
