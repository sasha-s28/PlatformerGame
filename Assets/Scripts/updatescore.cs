using System;
using UnityEngine;

public class updatescore : MonoBehaviour
{
    
    public int score; 

    public static event Action <int> actualitzar;

    private void OnEnable()
    {
        coin.coinrecollit += UpdateScore;
        
    }
    private void OnDisable()
    {
        coin.coinrecollit -= UpdateScore;
    }

    private void UpdateScore(coin coin)
    {
        score += coin.CoinValue;  
        actualitzar?.Invoke(score);
    }

}
