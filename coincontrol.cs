using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coincontrol : MonoBehaviour
{
    [SerializeField] float rotateSpeed;
    [SerializeField] AudioSource pickSound;

    private void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        pickSound.Play();
        Destroy(gameObject);
    }
}

