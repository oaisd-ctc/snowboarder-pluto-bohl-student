using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float timeToReload = 1.2f;
    [SerializeField] ParticleSystem finishEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("You Win!");
            finishEffect.Play();
            Invoke("ReloadScene", timeToReload);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
