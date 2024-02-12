using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public Text scoretext;
    public int playerScore = 0;
    public GameObject gameoverScreen;
    public bool IsAlive = true;
    public GameObject winScreen;
    public bool IsWin = false;
    public GameObject startScreen;
    public bool IsStart = false;
    public GameObject scoreBoard;
    public GameObject ferikli;
    public GameObject spawner;
    public GameObject[] buttons;
    public int increase = 5;
    public void ChangeColor(int i, Color color)
    {
        buttons[i].GetComponent<Image>().color = color;
    }
    public void Easy()
    {
        ChangeColor(0, Color.blue);
        ChangeColor(1, Color.white);
        ChangeColor(2, Color.white);
        increase = 10;
    }
    public void Medium()
    {
        ChangeColor(1, Color.green);
        ChangeColor(2, Color.white);
        ChangeColor(0, Color.white);
        increase = 5;
    }
    public void Hard()
    {
        ChangeColor(2, Color.red);
        ChangeColor(0, Color.white);
        ChangeColor(1, Color.white);
        increase = 1;
    }
    [ContextMenu("Increase")]
    public void IncreaseScore()
    {
        playerScore += increase;
        scoretext.text = playerScore.ToString();
    }
    public void RestarGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Gameover()
    {
        gameoverScreen.SetActive(true);
        IsAlive = false;
    }
    public void Win()
    {
        winScreen.SetActive(true);
        IsAlive = false;
        IsWin = true;
    }
    public void Begin()
    {
        
        startScreen.SetActive(false);
        IsStart = true;
        scoreBoard.SetActive(true);
        ferikli.SetActive(true);
        spawner.SetActive(true);
    }

 
}
