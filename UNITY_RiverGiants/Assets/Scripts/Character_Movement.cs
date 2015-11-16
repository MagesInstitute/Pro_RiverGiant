using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Character_Movement : MonoBehaviour
{
    public Transform joystiq;

    public GameObject joystiqgrp;

    public float jspeed = 0.1F;

    public float speed;

    private float cspeed;

    public float boostMult;

    float x;

    float y;

    bool boost;

    Quaternion newRotation;

    Vector2 startPos;

    Rigidbody2D rb;

<<<<<<< HEAD
=======
    void Awake()
    {
        GameManager.Initialize();
    }

>>>>>>> 0731be77a3d608a1d550e5db4736013694bb23a8
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

<<<<<<< HEAD
=======
    void OnTriggerEnter2D (Collider2D col)
    {
        switch (col.tag)
        { 
            case "Food":
                GameManager.OnHitFood(col.GetComponent<FishMovement>().sizeGrowth);
                ScoreManager.AddScore(col.GetComponent<FishMovement>().scoreValue);
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
>>>>>>> 0731be77a3d608a1d550e5db4736013694bb23a8

    public void Boost()
    {
        boost = true;
        StartCoroutine(BoostUp_());
    }

    public void StopBoost()
    {
        boost = false;
        speed = 30;
        StartCoroutine(BoostDown_());
    }

    IEnumerator BoostUp_()
    {
        for (float i = 0; i <= 1 && boost; i += Time.deltaTime) 
        {

            cspeed = speed + (boostMult * i);
            yield return null;
        }
    }

    IEnumerator BoostDown_()
    {
        for (float i = 0; i <= 1 && boost==false; i += Time.deltaTime)
        {

            cspeed = speed + (boostMult * -i);
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            joystiqgrp.SetActive(true);
            // Get movement of the finger since last frame
            startPos = Input.GetTouch(0).position;

            cspeed = 15;

            joystiqgrp.transform.position = startPos;
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 movePos = Input.GetTouch(0).position - startPos;

            joystiq.localPosition = Vector2.ClampMagnitude(movePos*jspeed, 120);

            x = joystiq.localPosition.x;

            y = joystiq.localPosition.y;
            
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            joystiqgrp.SetActive(false);
        }

        if (Input.touchCount == 0)
        {
            cspeed = 0;
        }
<<<<<<< HEAD
        rb.AddForce (new Vector2(x  * cspeed * Time.deltaTime, y  * cspeed * Time.deltaTime), ForceMode2D.Force );
        // transform.Translate(x/100 * cspeed * Time.deltaTime, y/100 * cspeed * Time.deltaTime, 0, Camera.main.transform);
=======
        rb.AddForce(new Vector2(x * cspeed * Time.deltaTime, y * cspeed * Time.deltaTime), ForceMode2D.Force);
        //transform.Translate(x/100 * cspeed * Time.deltaTime, y/100 * cspeed * Time.deltaTime, 0, Camera.main.transform);
>>>>>>> 0731be77a3d608a1d550e5db4736013694bb23a8
        newRotation = Quaternion.LookRotation(new Vector3(x,y,0));
        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime * cspeed);
    }
}
