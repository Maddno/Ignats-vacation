using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float reloadFinishTime = 2f;
    [SerializeField] ParticleSystem finishEffect;
    bool finished = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && !finished)
        {
            finished = true;
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", reloadFinishTime);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
