using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] float speed = 1f;
    [SerializeField] int value = 50;

    Coin coin;


    void Update()
    {

        transform.Translate(Vector2.up * speed * Time.deltaTime);

    }


    public void OnMouseDown()
    {
        FindObjectOfType<CoinDisplay>().AddCoins(value);
        Destroy(gameObject);
    }

    /*public void AddCoins(int amount)
    {
        FindObjectOfType<CoinDisplay>().AddCoins(amount);
    }*/

}
