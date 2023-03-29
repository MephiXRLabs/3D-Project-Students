using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    [SerializeField]
    private Vector3 _dir;

    [SerializeField]
    private float _forceModulo;

    private void OnCollisionEnter(Collision other)
    {
   
        if (other.gameObject.TryGetComponent<Sphere>(out var sphere))
        {
            sphere.rb.AddForce(_forceModulo * _dir);
        }
    }
}
