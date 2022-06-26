using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMushroom : MonoBehaviour
{
    
    [SerializeField] private UI_Manager _uiManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gun"))
        {
            Debug.Log("Mushroom-Gun Collision!, WIN!");
            //_uiManager.Win();
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
