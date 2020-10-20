using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyScript : MonoBehaviour
{

    public Text goldText;
    public int goldPerClick;

    private int gold;

    public int CurrentGold
    {
        get => gold;
        private set
        {
            gold = Mathf.Clamp(value, 0, 9999999);
            goldText.text = gold.ToString("0,000,000$");
        }
    }

    private void Start()
    {
        CurrentGold = PlayerPrefs.GetInt("Gold", 0);
    }

    public void OnButtonClicked()
    {
        CurrentGold += goldPerClick;
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetInt("Gold", CurrentGold);
    }
}
