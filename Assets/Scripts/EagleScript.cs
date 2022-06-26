using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleScript : MonoBehaviour
{
    [SerializeField] public GameObject target;
    [SerializeField] public float _eagleSpeed = 0.3f;
    private Animator animator;
    private float _distance;
    private float _distance1;
    private GunScript _gunScript;
   
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject != null && target.gameObject != null && !this.animator.GetBool("isDead"))
        {
            //y - 0.65f / z + 0.05f
            transform.position = Vector3.MoveTowards(this.transform.position,
                new Vector3(target.transform.position.x, target.transform.position.y - 0.65f,
                    target.transform.position.z + 0.5f), _eagleSpeed);

        }

        if (this.gameObject != null)
        {
            this.gameObject.SetActive(true);
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("isDead: "+ this.animator.GetBool("isDead"));
        if (this!= null && other != null && this.gameObject != null && other.gameObject != null && !this.animator.GetBool("isDead"))
        {
            if (other.gameObject.CompareTag("Bullet"))
            {
                animator.SetTrigger("isDead");
                //Debug.Log("Eagle-Bullet Collision!, Eagle die");
                //this.gameObject.SetActive(false);
                //Destroy (this);
            }
            else if (other.gameObject.CompareTag("Gun"))
            {
                //Debug.Log("Eagle-Gun Collision!, minimize lives");
                other.GetComponent<GunScript>().PlayerDeath();
                //Destroy(this.gameObject);
                //flyaway();
            }
        }

    }
    

}
