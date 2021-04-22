using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Return_To_Main_Screen : MonoBehaviour
{
    void Update() {
        if (Input.GetButtonDown("Cancel")) {
            SceneManager.LoadScene("main_screen");
        }
    }
    void OnMouseDown() {
        SceneManager.LoadScene("main_screen");
    }
}
