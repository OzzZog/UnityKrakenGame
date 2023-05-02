using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(Slider))]
public class ExperienceBar : MonoBehaviour
{
    Slider _expSlider;

    [Header("Text")]
    [SerializeField] [Tooltip("The player's current level")]
    private TextMeshProUGUI _currentExperienceText;
    [SerializeField] [Tooltip("The player's current experience")]
    private TextMeshProUGUI _currentLevelText;
    [SerializeField] [Tooltip("The experience cap to level up")]
    private TextMeshProUGUI _maxExperienceText;

    [Header("Display")]
    [SerializeField] 
    private bool _displayExperienceBar = true;
    [SerializeField]
    private bool _displayExperienceText = true;

    private void Awake()
    {
        if (_displayExperienceBar == false)
            gameObject.SetActive(false);

        _expSlider = GetComponent<Slider>();    
    }

    public void SetExperience(int exp)
    {
        _expSlider.value = exp;

        if (_displayExperienceText == false)
            _currentExperienceText.enabled = false;

        _currentExperienceText.text = _expSlider.value.ToString();
    }

    public void SetMaxExperience(int exp)
    {
        _expSlider.maxValue = exp;

        if (_displayExperienceText == false)
            _maxExperienceText.enabled = false;

        _maxExperienceText.text = _expSlider.maxValue.ToString();
    }

    public void SetLevelText(int level)
    {
        _currentLevelText.text = "Level: " + level.ToString();
    }
}
