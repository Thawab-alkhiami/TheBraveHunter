using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private Text _livestext;
    [SerializeField] private Text _desctext;

    public void UpdateLives(int health)
    {
        _livestext.text = "Lives: " + health;
    }
    
    public void EndGame()
    {
        _livestext.text = "GAME OVER! ";
        _desctext.text = "GAME OVER! ";
        _livestext.color = Color.red;
        _desctext.color = Color.red;
        _livestext.fontSize = 48;
        _desctext.fontSize = 48;
    }
    
    public void Win()
    {
        _livestext.text = "Congrats! ";
        _desctext.text = "Congrats! ";
        _livestext.color = Color.blue;
        _desctext.color = Color.blue;
        _livestext.fontSize = 48;
        _desctext.fontSize = 48;
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
