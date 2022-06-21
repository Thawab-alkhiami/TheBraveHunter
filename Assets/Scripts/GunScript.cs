using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    private float _speed = 50f ;
    [SerializeField] public float _walkSpeed = 5f;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, -1.7f, -6);
    }

    // Update is called once per frame
    void Update()
    {
        GunMovement();
    }

    public void GunMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(0f, Time.deltaTime * _speed * horizontalInput, 0f);

        float verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * _speed * verticalInput);
        //transform.Rotate(Time.deltaTime * _speed * verticalInput * -1,0f,0f);
        

    }
}
