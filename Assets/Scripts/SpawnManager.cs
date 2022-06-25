using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private bool _alive = true;
    [SerializeField] public GameObject _enemyPrefab;
    private GameObject playerObject;
    private float _delay = 5f;
    //private GameObject[] eagleObjectList;
    
    // Start is called before the first frame update
    void Start()
    {
        //playerObject = (GameObject)Instantiate(_playerPrefab , new Vector3(0,0, 0), Quaternion.identity);
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
            //_enemyPrefab = new GameObject();
            GameObject eagleObject = (GameObject)Instantiate(_enemyPrefab,
                new Vector3(Random.Range(-10f, 10f), Random.Range(2f, 5f), Random.Range(10f, 15f)),
                transform.rotation * Quaternion.Euler(0f, 180f, 0f));
            yield return new WaitForSeconds(_delay);
        }
        
    }
    
    public void stop()
    {
        Debug.Log("_alive = false");
        _alive = false;
    }
}
