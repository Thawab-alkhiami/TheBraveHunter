using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField] public float _rotationSpeed = 50f ;
    [SerializeField] public float _bulletSpeed = 20f;
    [SerializeField] public float _walkSpeed = 3f;
    [SerializeField] public GameObject _bullet;

    private int _lives = 3;
    
    // fire time delay
    private float _nextFireTime = 0f;
    private float _fireCoolDownTime = 0.5f;
    
    [SerializeField] private GameObject SpawnManager;
   
    void Start()
    {
        transform.position = new Vector3(0f, 0f, 0f);
    }

    void Update()
    {
        GunMovement();
        Shoot();
    }

    public void GunMovement()
    {
       // if (transform.position.x < 11f && transform.position.x > -16f && transform.position.z < 15f &&  transform.position.z > -13f)
        
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(0f, Time.deltaTime * _rotationSpeed * horizontalInput, 0f);

        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * _walkSpeed * verticalInput);
        //transform.Rotate(Time.deltaTime * _speed * verticalInput * -1,0f,0f);
        
    }

    public void Shoot()
    {
        if (Input.GetButtonDown("Jump") && _nextFireTime < Time.time) //space button
        {
            Instantiate(_bullet, // an object to instantiate
                    new Vector3(transform.position.x,transform.position.y - 0.035f,transform.position.z + 0.25f), //3D position
                    transform.rotation);
            
            
            //make interval between shots
            _nextFireTime = Time.time + _fireCoolDownTime;
            
            //turn off collisions between the bullet and the gun
            //Physics.IgnoreCollision(instantiatedBullet.GetComponent<Collider>(), transform.root.GetComponent<Collider>());
        }
    }

    public void PlayerDeath()
    {
        _lives--;
        Debug.Log("_lives after: "+_lives);
        if (_lives == 0)
        {
            Debug.Log("player death ");
            //SpawnManager.GetComponent<SpawnManager>().onPlayerDeath();
            //Destroy(this.gameObject);
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (this.gameObject != null && other.gameObject != null)
        {
            if (other.gameObject.CompareTag("Eagle"))
            {
                Debug.Log("Gun-Eagle Collision!");
            }
            else if(other.gameObject.CompareTag("Ground"))
            {
                Debug.Log("Gun-GroundGround Collision!, ignore!");
            }
            else if (other.gameObject.CompareTag("Mushroom"))
            {
                Debug.Log("Gun-Mushroom Collision!, WIN!");
            }
            else
            {
                Debug.Log("Gun-other Collision!, move back!");
                transform.Translate(Vector3.back * 1f);
                //GetComponent<Rigidbody>().AddForce(Vector3.up * 0.5f);
            }
        }

    }
}
