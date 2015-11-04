using UnityEngine;
using System.Collections;

public class Char2 : MonoBehaviour {

    void Awake()
    {
        Controller.attackEvent += PunchDown;
    }

    void PunchDown()
    {
        transform.Translate(0, -3, 0);
    }

}
