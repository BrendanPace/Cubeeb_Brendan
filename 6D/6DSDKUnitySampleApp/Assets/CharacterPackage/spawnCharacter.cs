using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCharacter : MonoBehaviour {

    public GameObject player;


    public void spawn()
    {
        Instantiate(player);//, new Vector3(x, y, 0), Quaternion.identity);
    }
	
}
