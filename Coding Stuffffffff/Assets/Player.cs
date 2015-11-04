using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
    void OnMouseDown()
    {
        GMS.score += 1;
        print(GMS.score);
    }

    void OnMouseExit()
    {
        GMS.Count();
        print(GMS.score);
    }

	// Update is called once per frame
	void Update ()
    {
	}
}
