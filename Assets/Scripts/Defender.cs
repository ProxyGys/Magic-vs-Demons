﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int coinCost = 100;



    public int GetCoinCost()
    {
        return coinCost;
    }



    //automotive add coins
    /*public void AddCoins(int amount)  
    {
        FindObjectOfType<CoinDisplay>().AddCoins(amount);
    }*/




}
