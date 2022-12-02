using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem particleSystem;

    private void OnCollisionExit2D(Collision2D other) {
        particleSystem.loop = false;
        particleSystem.Stop();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        particleSystem.loop = true;
        particleSystem.Play();
    }
}
