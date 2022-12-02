using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    bool isAlive = true;
    Rigidbody2D rigidbody;
    SurfaceEffector2D surfaceEffector;
    [SerializeField] float torqueAmount = 3f;
    [SerializeField] float boostSpeed = 50f;
    [SerializeField] float baseSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isAlive)
        {
            RotatePlayer();
            RespondToBoost();
        }
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector.speed = boostSpeed;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            surfaceEffector.speed = baseSpeed;
        }

    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddTorque(-torqueAmount);
        }
    }

    public bool GetIsAlive() {
        return isAlive;
    }

    public void DisableControls()
    {
        isAlive = false;
    }
}
