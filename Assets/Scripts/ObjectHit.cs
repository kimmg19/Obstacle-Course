using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectHit : MonoBehaviour {
    private void OnCollisionEnter(Collision collision) {
        if (collision != null&&collision.gameObject.tag=="Player") {
            MeshRenderer obj = gameObject.GetComponent<MeshRenderer>();
            obj.material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}
