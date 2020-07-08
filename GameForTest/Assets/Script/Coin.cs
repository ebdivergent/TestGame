using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag ("bullet"))
        {
            Score.instance.ChangeScore(coinValue);
        }
    }
}
