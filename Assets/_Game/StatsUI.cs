using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatsUI : MonoBehaviour
{
    [Header("Text")]
    [SerializeField] private TextMeshProUGUI _statsText;

    [Header("Display")]
    [SerializeField] private bool _displayStats;

    private void Awake()
    {
        if (_displayStats == false)
            gameObject.SetActive(false);
    }

    public void SetStats(int health, int damage, int speed)
    {
        _statsText.text = "Health: " + health.ToString() + " Damage: "
            + damage.ToString() + " Speed: " + speed.ToString();
    }
}
