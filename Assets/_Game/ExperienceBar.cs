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
    [SerializeField] private TextMeshProUGUI _currentExperienceText;
    [SerializeField] private TextMeshProUGUI _maxExperienceText;
    [SerializeField] private TextMeshProUGUI _currentLevelText;

    [Header("Display")]
    [SerializeField] private bool _displayExperienceBar;
    [SerializeField] private bool _displayStats;

    private void Awake()
    {
        if (_displayExperienceBar == false)
            gameObject.SetActive(false);

        _expSlider = GetComponent<Slider>();    
    }

    public void SetExperience(int exp)
    {
        _expSlider.value = exp;
        _currentExperienceText.text = _expSlider.value.ToString();
    }

    public void SetMaxExperience(int exp)
    {
        _expSlider.maxValue = exp;
        _maxExperienceText.text = _expSlider.maxValue.ToString();
    }

    public void SetLevelText(int level)
    {
        _currentLevelText.text = "Level: " + level.ToString();
    }
}
