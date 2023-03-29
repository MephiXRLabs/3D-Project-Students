using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] private bool _shouldMoveByForce;
    [SerializeField] private bool _shouldMoveByMovePosition;

    [SerializeField] private float _velocityModulo;
    [SerializeField] private Vector3 _dir;
    [SerializeField] private Transform _target;
    
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

}
