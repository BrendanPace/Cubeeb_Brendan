using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterContoller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void forward()
    {
        transform.Translate(Vector3.forward *1);
    }

    public void back()
    {
        transform.Translate(Vector3.back * 1);
    }

    public void jump()
    {
        transform.Translate(Vector3.up * 3);
    }

    public void spawn()
    {
        this.gameObject.SetActive(true);
    }
}
