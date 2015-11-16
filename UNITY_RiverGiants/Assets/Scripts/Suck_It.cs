using UnityEngine;
using System.Collections;

public class Suck_It : MonoBehaviour {

    Vector3 initPos;

    public float speed;

    float t;

	// Use this for initialization
	void Start ()
    {
	}
	
    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag == "Player")
        {

            initPos = transform.position;

            float distance = Vector3.Distance(col.transform.position, initPos);

            StartCoroutine(SuckIt(col.transform, distance));
        }
    }

    IEnumerator SuckIt(Transform col, float distance)
    {

        while (distance > 0.1)
        {
            t += speed * Time.deltaTime;

            transform.position = Vector3.Lerp(initPos, col.transform.position, t);

            distance = Vector3.Distance(col.transform.position,initPos);

            yield return null;
        }

    }

	// Update is called once per frame
	void Update () {
	
	}
}
