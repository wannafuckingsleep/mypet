using System.Collections;
using UnityEngine;

public class Spawn_Bombs : MonoBehaviour
{
    public GameObject bomb;
    private float spawn_time = 2f;
    void Start() {
        StartCoroutine (Spawn());
    }
    IEnumerator Spawn() {
        while (!Player.lose) {
            Instantiate(bomb, new Vector2 (Random.Range(-2.5f, 2.5f), 5.9f), Quaternion.identity);
            spawn_time = spawn_time * 0.95f;
            Fall_Down.fall_speed = Fall_Down.fall_speed + 0.05f;
            yield return new WaitForSeconds(spawn_time);
        }
    }
}
