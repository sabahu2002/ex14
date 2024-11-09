using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : Character
{
    

    public void Attack (Player p1,int amount)
    {
       p1.Health-=amount; 
       Debug.Log(p1.Health);
    }
}
