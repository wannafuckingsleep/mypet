using UnityEngine;
using UnityEngine.SceneManagement;
public class Show_Game_Screen : MonoBehaviour
{
    void OnMouseDown(){
        SceneManager.LoadScene("Games_Screen");
    }
}
