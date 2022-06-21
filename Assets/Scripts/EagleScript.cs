using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleScript : MonoBehaviour
{
    private Animator animator;
    private bool isAttacking = false;
    [SerializeField] public GameObject target;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
        Debug.Log("Distance: "+Vector3.Distance(this.transform.position, target.transform.position));
    }

    // Update is called once per frame
    void Update()
    {
        //if (Vector3.Distance(this.transform.position, target.transform.position) < 10 && !isAttacking)
        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Jump") && !isAttacking)
        {
            isAttacking = true;
            animator.SetTrigger("Attack");
            StartCoroutine(stopAttack(1));

        }
    }
    
    public IEnumerator stopAttack(float length)
    {
        yield return new WaitForSeconds(length);
        isAttacking = false;
    }
}
