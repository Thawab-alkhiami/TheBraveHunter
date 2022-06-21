using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bird"))
        {
            Debug.Log("Bird Collision!, Get a point");
            Destroy(other.gameObject);
        }/*else if (other.CompareTag("Player"))
        {
            Debug.Log("Player Collision!");
            other.GetComponent<PlayerBehaviour>().Damage();
            //Destroy(this.gameObject);
        } */
        else
        {
            Debug.Log("Other Collision!");
        }
        
    }
}
