using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] public float _bulletSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * _bulletSpeed * Time.deltaTime);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Eagle"))
        {
            Debug.Log("Eagle Collision!, Get a point");
        }
        else
        {
            Debug.Log("Other Collision!");
            Destroy(this);
        }
        
    }
    
}
