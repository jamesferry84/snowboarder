using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float finishDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            finishEffect.Play();
            Invoke("Finish", finishDelay);
        }
    }

    void Finish()
    {
        Debug.Log("Hit the Post. FInished Level");
        SceneManager.LoadScene(0);
    }
}
