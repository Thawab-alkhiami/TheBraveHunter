using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private bool _alive = true;
    [SerializeField] public GameObject _enemyPrefab;
    private float _delay = 2f;
    //private GameObject[] eagleObjectList;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnSystem());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    IEnumerator SpawnSystem()
    {
        Debug.Log("SpawnSystem: "+_alive);
        while (_alive)
        {
            GameObject eagleObject = (GameObject)Instantiate(_enemyPrefab , new Vector3(Random.Range(-3f,3f),Random.Range(2f,5f), Random.Range(-3f,3f)), transform.rotation * Quaternion.Euler (0f, 180f, 0f));
            //eagleObjectList.Append(eagleObject);
            yield return new WaitForSeconds(_delay);
        }
        
    }
    
    public void onPlayerDeath()
    {
        Debug.Log("_alive = false");
        _alive = false;
    }
}
