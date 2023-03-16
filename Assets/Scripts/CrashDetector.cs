using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float timeToReload = 0.5f;
    [SerializeField] ParticleSystem dead;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground")
        {
            Debug.Log("You Died.");
            dead.Play();
            Invoke("ReloadScene", timeToReload);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
