using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float timeToReload = 2f;
    [SerializeField] ParticleSystem dead;
    [SerializeField] AudioClip crashSFX;
    public bool isDead;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ground" && !isDead)
        {
            FindObjectOfType<PlayerController>().DisableControls();
            Debug.Log("You Died.");
            dead.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", timeToReload);
            isDead = true;
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
