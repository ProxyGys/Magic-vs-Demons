using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DefenderButton : MonoBehaviour
{

    [SerializeField] Defender defenderPrefab;


    private void Start()
    {
        LableButtonWithCost();
    }

    private void LableButtonWithCost()
    {
        Text costText = GetComponentInChildren<Text>();
        if (!costText)
        {
            Debug.LogError(name + "has no cost text!");
        }
        else
        {
            costText.text = defenderPrefab.GetCoinCost().ToString();
        }
    }

    private void OnMouseDown()
    {

        var butttons = FindObjectsOfType<DefenderButton>();
        foreach(DefenderButton button in butttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(54, 54, 54, 255);
        }
        
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<DefenderSpawner>().SetSelectedDefender(defenderPrefab);

    }


}
