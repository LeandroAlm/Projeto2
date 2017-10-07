using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSatatus : MonoBehaviour {

    public float hp;
    public float armor;
    public int wood, stone;
    

    public void StoneAmout(int valeu)
    {
        stone += valeu;
    }

    public void WoodAmout(int valeu)
    {
        wood += valeu;
    }
}
