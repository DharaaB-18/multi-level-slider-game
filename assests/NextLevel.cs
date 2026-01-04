using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private void OnCollisionEnter (Collision collision) {
        if (collision.collider.tag == "Next Level") {
            Debug.Log("Next level test");
            SceneManager.LoadScene("Level2");
        }
    }
}
