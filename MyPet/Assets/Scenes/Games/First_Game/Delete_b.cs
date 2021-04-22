using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_b : MonoBehaviour
{
    void Update () {
        if (transform.position.y < -6f) {
            Destroy(gameObject);
        }
    }
}
