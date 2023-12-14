using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;
    public int damage = 2;

    //кол-во монет
    public int coins;
    //Объект снаряда
    public GameObject fireballPrefab;
    //Место появления снаряда
    public Transform attackPoint;

    private void Update()
    {
        //Прин лкм
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }

        //Метод уменьшения здоровья
        public void TakeDamage(int damage)
        {
            health -= damage;
            print("Здоровье игрока:" + health);
        }

        public void CollectCoins()
        {
            coins += 1;
            print("Coins" + coins);
 }
