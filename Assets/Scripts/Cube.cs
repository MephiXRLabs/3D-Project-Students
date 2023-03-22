using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    private bool _shouldChangePosition;

    [SerializeField] private float _speed;

    // Start is called before the first frame update
    private void Start()
    {
        
    }
    
    // Update is called once per frame
    private void Update()
    {
        if (_shouldChangePosition)
        {
            transform.position += new Vector3(_speed * Time.deltaTime, 0, 0);
            //_shouldChangePosition = false;
        }

        Debug.Log($"Update {gameObject.name}");
    }
    
}
