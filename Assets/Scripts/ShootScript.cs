using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public Rigidbody projectile;
 
    public float speed = 20f;
    // fire time delay
    private float _nextFireTime = 0f;
    private float _fireCoolDownTime = 0.5f;
 
 
    // Use this for initialization
    void Start () {
   
    }
   
    // Update is called once per frame
    void Update () {
 
        if (Input.GetButtonDown("Jump") && _nextFireTime < Time.time) //space button
        {
            Rigidbody instantiatedBullet = Instantiate(projectile, // an object to instantiate
                    transform.position, //3D position
                    transform.rotation) // object rotation
                as Rigidbody;
            
            //move the bullet
            instantiatedBullet.velocity = transform.TransformDirection(new Vector3(0, 0,speed));
            
            //make interval between shots
            _nextFireTime = Time.time + _fireCoolDownTime;
            
            //turn off collisions between the bullet and the gun
            //Physics.IgnoreCollision(instantiatedBullet.GetComponent<Collider>(), transform.root.GetComponent<Collider>());
        }
    }
}
