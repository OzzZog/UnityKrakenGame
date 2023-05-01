using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experience : MonoBehaviour
{
    [Header("Experience")]
    [SerializeField] 
    private int _currentExperience = 0;
    [SerializeField] [Tooltip("Experience needed to level up")]
    private int _experienceCap = 100;
    [SerializeField] [Tooltip("How much should the maximum of experience increment by")] 
    private int _changeMaxExperience = 10;
    [SerializeField] 
    private int _currentLevel = 1;

    [Header("Player Stats")]
    [SerializeField] 
    private int _movementSpeed = 10;
    [SerializeField] 
    private int _currentHealth = 100;
    [SerializeField] 
    private int _maxHealth = 100;
    [SerializeField] 
    private int _damage = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LevelUp();
    }

    public void GainExperience(int experienceGained)
    {
        _currentExperience += experienceGained;
    }

    public void LoseExperience(int experienceLost)
    {
        _currentExperience -= experienceLost;
    }

    public void LevelUp()
    {
        if (_currentExperience == _experienceCap)
        {
            _currentExperience = 0;
            _currentLevel++;
            _experienceCap += _changeMaxExperience;
            IncreaseStats();
        }
    }

    public void IncreaseStats()
    {
        _movementSpeed++;
        _maxHealth++;
        _damage++;
    }
}
