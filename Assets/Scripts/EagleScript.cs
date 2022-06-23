using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleScript : MonoBehaviour
{
    [SerializeField] public GameObject target;
    [SerializeField] public float _eagleSpeed = 0.5f;
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
        if(this.gameObject != null && target.gameObject != null)
        {
            //y - 0.65f / z + 0.05f
            transform.position = Vector3.MoveTowards(this.transform.position,
                new Vector3(target.transform.position.x, target.transform.position.y - 0.65f,
                    target.transform.position.z + 0.5f), _eagleSpeed);

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("isDead: "+ this.animator.GetBool("isDead"));
        if (this.gameObject != null && other.gameObject != null)
        {
            if (other.gameObject.CompareTag("Bullet"))
            {
                animator.SetTrigger("isDead");
                Debug.Log("Bullet Collision!, Eagle die");
                //Destroy (gameObject, 5);
            }
            else if (other.gameObject.CompareTag("Gun"))
            {
                Debug.Log(animator.GetBool("isDead")+"Gun Collision!, minimize lives");
                other.GetComponent<GunScript>().PlayerDeath();
                //Destroy(this.gameObject);
                //flyaway();
            }
        }

    }
    

}
