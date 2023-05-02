using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScript : MonoBehaviour
{
    [SerializeField] Experience playerExperience;
    [SerializeField] private int getExperience = 20;
    [SerializeField] private int loseExperience = 20;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            playerExperience.GainExperience(getExperience);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerExperience.LoseExperience(loseExperience);
        }
    }
}
