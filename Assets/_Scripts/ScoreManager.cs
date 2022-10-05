using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour

{
    public static ScoreManager instance;
    int score = 0;
    public int PlayerLives = 3;

    private Text ScoreText;
    void Start()
    {
        ScoreText = GetComponent<Text>();
    }


    // Start is called before the first frame update
    void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }

    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        Debug.Log(score);
    }

    public void ReachedGoal()
    {
        score = score + PlayerLives;
        Debug.Log(score);
    }

    public void LoseLife(int damage)
    {
        PlayerLives -= damage;
        //SceneManager.LoadScene(0);
        Debug.Log(PlayerLives);
    }

    void Update()
    {
        ScoreText.text = ScoreManager.instance.score.ToString();
    }
}
