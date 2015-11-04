using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

    public delegate void AttackEvent();

    public static event AttackEvent attackEvent;

    void OnMouseDown()
    {
        attackEvent();
    }

}
