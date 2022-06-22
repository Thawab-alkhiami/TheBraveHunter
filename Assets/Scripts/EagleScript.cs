using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleScript : MonoBehaviour
{
    [SerializeField] public GameObject target;
    [SerializeField] public float _eagleSpeed = 0.5f;
    private Animator animator;
    private bool isAttacking = false;
    private float _distance;
    private float _distance1;
    private GunScript _gunScript;
    private Vector3 stageDimensions;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        _distance = (target.transform.position - this.transform.position).magnitude;
        _distance1 = Vector3.Distance(this.transform.position, target.transform.position);
        Debug.Log("_distance: "+_distance +" _distance1: " +_distance1);
        //convert the values to world point
        stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,0));
        Debug.Log("stageDimensions x: "+stageDimensions.x+" stageDimensions y: "+stageDimensions.y +" stageDimensions z: "+stageDimensions.z);

    }

    // Update is called once per frame
    void Update()
    {
        _distance = (target.transform.position - this.transform.position).magnitude;
        transform.position =
            Vector3.MoveTowards(transform.position, target.transform.position, _eagleSpeed * Time.time);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            animator.SetTrigger("isDead");
            Debug.Log("Bullet Collision!, Eagle die");
            //_eagleSpeed = 0f;
            
            //Destroy(this.gameObject);
        }else if (other.gameObject.CompareTag("Gun"))
        {
            Debug.Log("Gun Collision!, minimize lives");
            _gunScript = new GunScript();
            _gunScript.PlayerDeath();
            //flyaway();
        }
        
    }

    public void flyaway()
    {
        Debug.Log("flyaway!");
        transform.Translate(Vector3.left * Time.time * _eagleSpeed);

        if (transform.position.y > 10f)
        {
            Destroy(this.gameObject);
        }
    }

}
