using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private bool _shouldMoveByForce;
    [SerializeField] private bool _shouldMoveByMovePosition;

    [SerializeField] private float _velocityModulo;
    [SerializeField] private Vector3 _dir;
    [SerializeField] private Transform _target;
    
    
    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_shouldMoveByForce)
        {
            //_rb.velocity = _velocityModulo * _dir;
            //_rb.AddForce(_velocityModulo * _dir);
            _rb.AddTorque(_velocityModulo * _dir);
            _shouldMoveByForce = false;
        }

        if (_shouldMoveByMovePosition)
        {
            _rb.MovePosition(_target.position);
        }
    }
}
