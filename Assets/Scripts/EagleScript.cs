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
        //y - 0.65f / z + 0.05f
        {
            transform.position = Vector3.MoveTowards(this.transform.position,
                new Vector3(target.transform.position.x, target.transform.position.y - 0.65f,
                    target.transform.position.z +1f), _eagleSpeed);

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            animator.SetTrigger("isDead");
            Debug.Log("Bullet Collision!, Eagle die");
            Destroy(this.gameObject);
        }else if (other.gameObject.CompareTag("Gun"))
        {
            Debug.Log("Gun Collision!, minimize lives");
            other.GetComponent<GunScript>().PlayerDeath();
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
