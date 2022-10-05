using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthWatcher : MonoBehaviour
{
    public int ID = 0;
    // Update is called once per frame
    void Update()
    {
         if (ID == 3 && ScoreManager.instance.PlayerLives < 3)
            {
                Destroy(gameObject);
            };


        if (ID == 2 && ScoreManager.instance.PlayerLives < 2)
        {
            Destroy(gameObject);
        };

        if (ID == 1 && ScoreManager.instance.PlayerLives < 1)
        {
            Destroy(gameObject);
        };
    }
}
