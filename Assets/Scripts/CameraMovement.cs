using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Vector3 _offset;
    private Quaternion Turnto;
    private bool lookAtTarget = false;
    private float smoothFactor = 0.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - _target.transform.position;
        _offset = new Vector3(transform.position.x - _target.position.x, transform.position.y - _target.position.y,
            transform.position.z - _target.position.z+1f);
        Debug.Log("offset: "+_offset.ToString());
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (_target != null)
        {
            transform.position = _target.transform.position + new Vector3(0, 1, -2);
            //Vector3 newPosition = _target.transform.position + _offset;
            //transform.position = Vector3.Slerp(transform.position,newPosition, smoothFactor);
            //transform.LookAt(_target);
            transform.rotation = Quaternion.Slerp(transform.rotation, _target.transform.rotation, 0.5f);
            //transform.rotation = _target.rotation;
        }

        if (lookAtTarget)
        {
            transform.LookAt(_target);
        }
    }
}
