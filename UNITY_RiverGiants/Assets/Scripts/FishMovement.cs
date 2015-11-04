using UnityEngine;
using System.Collections;

public class FishMovement : MonoBehaviour
{
    Transform target;
    public float max = 5;
    public float min = 1;
    public float tSpeed = 1;
    public float multiplier = 3;

    float speed;
    Quaternion newRotation;
    Vector3 velocity;
    Vector3 previous;
    Vector3 offset;

    void Awake ()
    {
        speed = Random.Range(min, max);
    }

	// Use this for initialization
	void Start ()
    {
        offset = transform.localPosition;
        target = transform.parent.FindChild("MovingObject");
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset*multiplier, speed * Time.deltaTime);

        velocity = transform.position - previous;
        newRotation = Quaternion.LookRotation(velocity);
        previous = transform.position;
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * tSpeed);
	}
}
