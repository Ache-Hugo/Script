using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public TMPro.TextMeshProUGUI coins;
    public Slider health;
    public Player player;
    void Start()
    {
        coins.text = coins.text + player.coins;
        health.value = player.maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        coins.text = coins.text + player.coins;
        health.value = player.health; 
    }
}
