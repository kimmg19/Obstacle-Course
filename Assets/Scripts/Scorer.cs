using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour {
    float score = 0f;
    private void OnCollisionEnter(Collision collision) {
        if (collision != null && collision.gameObject.tag != "Hit") {
            score++;
            Debug.Log("score: " + score);

        }
    }
}
