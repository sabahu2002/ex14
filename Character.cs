using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    private string name = "";
    private int health = 100;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;

        }
    }
    public Character(string fname, int fhealth)
    {
        name = fname;
        health = fhealth;

    }
    

}
