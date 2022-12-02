using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float deathDelay = 2f;
    [SerializeField] ParticleSystem deathEffect;
    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.collider.GetType() == typeof(CircleCollider2D))
        {
            deathEffect.Play();
            Invoke("Death", deathDelay);
        }

    }


    void Death()
    {
        Debug.Log("Ouch... MY HEAD");
        SceneManager.LoadScene(0);
    }
}
