using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField]
    private int _speed;
    
    [SerializeField]
    [TextArea]
    private string _str;
    
    [SerializeField]
    [Range(0, 10)]
    private float _float;

    [SerializeField]
    private List<string> items = new List<string>();
    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log($"Awake {gameObject.name}");
    }

    private void OnEnable()
    {
        Debug.Log($"OnEnable {gameObject.name}");
    }

    private void Start()
    {
        Debug.Log($"Start {gameObject.name}");
    }

    private void FixedUpdate()
    {
        Debug.Log($"FixedUpdate {gameObject.name}");
    }

    // Update is called once per frame
    private void Update()
    {
        Debug.Log($"Update {gameObject.name}");
    }

    private void LateUpdate()
    {
        Debug.Log($"LateUpdate {gameObject.name}");
    }

    private void OnDisable()
    {
        Debug.Log($"OnDisable {gameObject.name}");
    }

    private void OnDestroy()
    {
        Debug.Log($"OnDestroy {gameObject.name}");
    }
}
