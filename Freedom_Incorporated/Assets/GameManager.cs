using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    Text CoinText;

    int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        CoinText = GameObject.Find("Coin Count").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        CoinText.text = score.ToString();
    }

    public void OnCoinPickup()
    {
        score += 1;

    }
}
