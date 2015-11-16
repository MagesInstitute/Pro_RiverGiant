using UnityEngine;
using System.Collections;

public class Eat_It : MonoBehaviour
{


    void OnTriggerEnter(Collider col)
    {
        switch (col.tag)
        {
            case "Food":
                print("Yummy");
                Destroy(col.gameObject);
                break;

            case "Poison":
                print("You have been poisoned");
                break;

            default:
                print("Ouch");
                break;
        }
    }
}
