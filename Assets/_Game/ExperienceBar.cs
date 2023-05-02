using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ExperienceBar : MonoBehaviour
{
    Slider expSlider;

    [Header("Text")]
    [SerializeField] private TextMeshProUGUI _currentExperienceText;
    [SerializeField] private TextMeshProUGUI _maxExperienceText;
    [SerializeField] private TextMeshProUGUI _currentLevelText;

    private void Awake()
    {
        expSlider = GetComponent<Slider>();    
    }

    public void SetExperience(int exp)
    {
        expSlider.value = exp;
        _currentExperienceText.text = expSlider.value.ToString();
    }

    public void SetMaxExperience(int exp)
    {
        expSlider.maxValue = exp;
        _maxExperienceText.text = expSlider.maxValue.ToString();
    }

    public void SetLevelText(int level)
    {
        _currentLevelText.text = "Level: " + level.ToString();
    }
}
