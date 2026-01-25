using System;
using UnityEngine;

public class coin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int CoinValue =10;

    public static event Action<coin> coinrecollit;  //creació del event  

    private void OnTriggerEnter2D(Collider2D collision)
    {
        coinrecollit?.Invoke(this);
            Destroy(gameObject);
        
    }
  
}
