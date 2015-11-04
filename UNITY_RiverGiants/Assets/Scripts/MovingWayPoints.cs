using UnityEngine;
using System.Collections;

public class MovingWayPoints : MonoBehaviour
{
    public Transform[] targets;
    int targetCount = 0;
    public int maxSpeed;
    public int minSpeed;
    int speed;
	
    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

	// Update is called once per frame
	void Update ()
    {
        int maxArray = targets.Length;
        Vector3 currentPos = transform.position;
        Vector3 targetPos = targets[targetCount].position;
        Vector3 delta = targetPos - currentPos;
        Vector3 direction = delta.normalized;
        float distance = delta.magnitude;

        if (distance < 1)
        {
            speed = Random.Range(minSpeed, maxSpeed);
            targetCount = Random.Range(0, maxArray);
            if (targetCount >= maxArray)
                targetCount = 0;
            return;
        }

        Vector3 newPos = direction * speed * Time.deltaTime;
        newPos += currentPos;
        transform.position = newPos;
    }
}
