using UnityEngine;
using UnityEngine.SceneManagement;

public class Start_First_Game : MonoBehaviour
{
    void OnMouseDown() {
        Player.lose = false;
        SceneManager.LoadScene("First_Game");
    }
}
