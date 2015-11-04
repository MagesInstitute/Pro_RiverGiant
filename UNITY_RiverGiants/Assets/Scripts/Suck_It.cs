using UnityEngine;
using System.Collections;

public class Suck_It : MonoBehaviour {

    float distance;

    Vector3 initPos;

    public float speed;

    float t;

	// Use this for initialization
	void Start ()
    {
	}
	
    void OnTriggerEnter (Collider col)
    {
        if (col.tag == "Food")
        {
            FishMovement suckedit = col.gameObject.GetComponent<FishMovement>();

            suckedit.sucked = false;

            initPos = col.transform.position;

            distance = Vector3.Distance(transform.position, initPos);

            StartCoroutine(SuckIt(col.transform));
        }
    }

    IEnumerator SuckIt(Transform col)
    {
        while (distance > 0.1)
        {
            t += speed * Time.deltaTime;

            col.position = Vector3.Lerp(initPos, transform.position, t);

            distance = Vector3.Distance(transform.position,initPos);

            yield return null;
        }

    }

	// Update is called once per frame
	void Update () {
	
	}
}
