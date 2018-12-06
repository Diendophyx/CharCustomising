using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int strength;
    public int dexterity;
    public int speed;
    public int intelligence;
    public int charisma;

    [Header("UI")]
    public Text strengthText;
    public Text dexterityText;
    public Text speedText;
    public Text intelligenceText;
    public Text charismaText;

    void UpdateUI()
    {
        strengthText.text = "Strength = " + strength.ToString();
        dexterityText.text = "Dexterity = " + dexterity.ToString();
        speedText.text = "Speed = " + speed.ToString();
        intelligenceText.text = "intelligence = " + intelligence.ToString();
        charismaText.text = "charisma = " + charisma.ToString();
    }

    public void IncreaseStrength(int value)
    {
        strength += value;
        UpdateUI();
    }

    public void IncreaseDexterity(int value)
    {
        dexterity += value;
        UpdateUI();
    }

    public void IncreaseSpeed(int value)
    {
        speed += value;
        UpdateUI();
    }
    public void Increaseintelligence(int value)
    {
        intelligence += value;
        UpdateUI();
    }
    public void Increasecharisma(int value)
    {
        charisma += value;
        UpdateUI();
    }


    // Use this for initialization
    void Start()
    {
        UpdateUI();
    }
}
