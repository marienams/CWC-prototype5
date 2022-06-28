using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{

    private Button button;
    public GameManagement gameManager;
    
    public int difficulty;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(setDifficulty);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManagement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

void setDifficulty()
    {
        //titleScreen.gameObject.SetActive(false);
        gameManager.StartGame(difficulty);
        Debug.Log(gameObject.name + "was clicked");
    }
}
