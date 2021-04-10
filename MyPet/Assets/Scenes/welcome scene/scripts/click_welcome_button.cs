using UnityEngine;
using UnityEngine.SceneManagement;
public class click_welcome_button : MonoBehaviour
{
    void OnMouseDown(){
        SceneManager.LoadScene("main_screen");
    }
}
