using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketMotion : MonoBehaviour
{
    private Rigidbody rigidbody;
    [SerializeField] float rocketThrust = 1000f;
    [SerializeField] float rocketRotation = 1f;
    private AudioSource audioSource;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        processThrust();
        processRotation();
    }

    void processThrust()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * rocketThrust);
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
                Debug.Log("Music");
            }
        }
        else
        {
            if (audioSource.isPlaying)
            {
                audioSource.Stop(); // Stop the audio when the thrust is not applied
            }
        }
    }

    void processRotation()
    {
        if (Input.GetKey(KeyCode.J))
        {
            transform.Rotate(Vector3.forward);
        }
        else if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(Vector3.back);
        }
    }
}
