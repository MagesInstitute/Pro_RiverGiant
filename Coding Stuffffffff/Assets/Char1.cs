using UnityEngine;
using System.Collections;

public class Char1 : MonoBehaviour {

    void Awake()
    {
        Controller.attackEvent += PunchUp;
    }

    void PunchUp()
    {
        transform.Translate(0, 3, 0);
    }

}
