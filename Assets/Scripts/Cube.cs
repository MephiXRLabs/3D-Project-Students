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
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
