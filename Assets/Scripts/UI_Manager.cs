using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private Text _livestext;

    public void UpdateLives(int health)
    {
        _livestext.text = "Lives: " + health;
    }
    
    public void EndGame()
    {
        _livestext.text = "GAME OVER! ";
    }
    
    public void Win()
    {
        _livestext.text = "Congrats! ";
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
