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
    
    // Start is called before the first frame update
    void Start()
    {
        //animator = this.GetComponent<Animator>();
        animator = GetComponentInChildren<Animator>();
        _distance = (target.transform.position - this.transform.position).magnitude;
        _distance1 = Vector3.Distance(this.transform.position, target.transform.position);
        Debug.Log("_distance: "+_distance +" _distance1: " +_distance1);
    }

    // Update is called once per frame
    void Update()
    {
        _distance = (target.transform.position - this.transform.position).magnitude;
        //if (_distance < 3 && !isAttacking)
        //if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump") 
            //&& !isAttacking
        //    )
        //{
        //transform.Rotate(50f, 0f , 0f);
        //transform.up = target.transform.position - transform.position;
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, _eagleSpeed * Time.time);

            //isAttacking = true;

        //}
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Gun") )
        {
            animator.SetTrigger("isDead");
            Debug.Log("Gun Collision!, dstroy!");
            _eagleSpeed = 0f;
            
            //Destroy(this.gameObject);
        }
        
    }

    void Attack()
    {
        transform.Rotate(50f, 0f , 0f);
    }
    
    public IEnumerator stopAttack(float length)
    {
        yield return new WaitForSeconds(length);
        isAttacking = false;
    }
}
