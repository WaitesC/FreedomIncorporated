using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupController : MonoBehaviour
{
    GameManager gameManager;
    //Text CoinText;

    //int score;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        //score = 0;
        //CoinText = GameObject.Find("Score").GetComponent<Text>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //CoinText.text = score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            gameManager.OnCoinPickup();
            CoinStuff();

        }
    }

    void CoinStuff()
    {
        //score += 1;
        Destroy(gameObject);

    }
}
