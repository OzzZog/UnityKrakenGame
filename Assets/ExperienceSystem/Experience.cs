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
    [SerializeField] [Tooltip("Increases maximum of experience when leveling up")] 
    private int _changeMaxExperience = 10;
    [SerializeField] 
    private int _currentLevel = 1;

    [Header("Player Stats")]
    [SerializeField] 
    private int _maxHealth = 100;
    [SerializeField] [Tooltip("Health amount increase when leveling up")]
    private int _maxHealthIncreaseAmount = 20;
    [SerializeField] [Space(5)]
    private int _damage = 7;
    [SerializeField] [Tooltip("Damage amount increase when leveling up")]
    private int _damageIncreaseAmount = 5;
    [SerializeField] [Space(5)]
    private int _movementSpeed = 5;
    [SerializeField] [Tooltip("Movement speed amount increase when leveling up")]
    private int _movementSpeedIncreaseAmount = 2;

    [Header("UI")]
    [SerializeField] private ExperienceBar experienceBar;
    [SerializeField] private StatsUI statsUI;

    void Start()
    {
        experienceBar.SetExperience(_currentExperience);
        experienceBar.SetMaxExperience(_experienceCap);
        experienceBar.SetLevelText(_currentLevel);
        statsUI.SetStats(_maxHealth, _damage, _movementSpeed);
    }

    void Update()
    {
        if(_currentExperience >= _experienceCap)
        {
            LevelUp();
        }
    }

    public void GainExperience(int experienceGained)
    {
        _currentExperience += experienceGained;
        experienceBar.SetExperience(_currentExperience);
    }

    // Check to make sure exp does not go below 0
    public void LoseExperience(int experienceLost)
    {
        if(_currentExperience - experienceLost <= 0)
        {
            _currentExperience = 0;
        }
        else
        {
            _currentExperience -= experienceLost;
        }
        experienceBar.SetExperience(_currentExperience);
    }

    public void LevelUp()
    {
        _currentLevel++;
        experienceBar.SetLevelText(_currentLevel);

        // Experience carry over to next level
        int leftOverExperience = Mathf.Abs(_experienceCap - _currentExperience);
        _currentExperience = leftOverExperience;
        experienceBar.SetExperience(_currentExperience);

        _experienceCap += _changeMaxExperience;
        experienceBar.SetMaxExperience(_experienceCap);

        IncreaseStats();
    }

    public void IncreaseStats()
    {
        _maxHealth += _maxHealthIncreaseAmount;
        _damage += _damageIncreaseAmount;
        _movementSpeed += _movementSpeedIncreaseAmount;

        statsUI.SetStats(_maxHealth, _damage, _movementSpeed);
    }
}
