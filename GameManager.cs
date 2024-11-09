using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        Player p1 = new Player("ss", 10);
        Enemy e1 = new Enemy("enemy1", 100);
        Debug.Log("Palyer name = " + p1.Name + " " + "Player Health = " + p1.Health);
        Debug.Log("Enemy name = " + e1.Name + "Enemy Health = " + e1.Health);

        p1.Heal(20);

        e1.Attack(p1, 2);
    }
}
