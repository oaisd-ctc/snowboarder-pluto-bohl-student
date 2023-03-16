using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float timeToReload = 2.6f;
    [SerializeField] ParticleSystem finishEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !FindObjectOfType<CrashDetector>().isDead)
        {
            Debug.Log("You Win!");
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", timeToReload);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
