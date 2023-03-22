using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

    [SerializeField] private GameObject _cube1;
    [SerializeField] private MeshRenderer _renderer;

    [SerializeField] private bool _shouldChangeColor;

    [SerializeField] private Color _color;

    // Start is called before the first frame update
    private void Start()
    {
        _cube1 = GameObject.FindGameObjectWithTag("Cube1");
        _renderer = _cube1.GetComponent<MeshRenderer>();
    }
    
    // Update is called once per frame
    private void Update()
    {
        if (_shouldChangeColor)
        {
            //TODO Change color
            _renderer.material.color = _color;
            _shouldChangeColor = false;
        }

        Debug.Log($"Update {gameObject.name}");
    }
    
}
