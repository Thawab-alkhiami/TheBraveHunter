using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Vector3 _offset;
    
    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - _target.transform.position;
        Debug.Log(_offset);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (_target != null)
        {
            transform.position = _target.transform.position + _offset;
             transform.rotation = _target.transform.rotation;
        }
    }
}
