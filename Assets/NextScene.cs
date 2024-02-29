using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [SerializeField] int SceneIndex;
    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            SceneManager.LoadScene(SceneIndex);
        }
    }
}
