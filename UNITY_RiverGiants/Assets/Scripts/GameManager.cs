using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour 
{
    public static float health = 100f;
	public static float size = 1f;
	public static float maxSize = 5f;
	public static float stamina = 100f;
    public static Transform sizeBar;

    public static void Initialize()
    {
        sizeBar = GameObject.Find("SizeBar").transform;
    }
	
	public static void OnHitFood(float value)
	{
		size += value;
		if(size >= maxSize)
			Debug.Log("Size already exceed/reached maxSize");

        sizeBar.localScale = new Vector3(Mathf.Clamp(size / maxSize, 0, 1), 1,1);
    }
	
	public static void OnHitObstacles(float value)
	{
		health -= value;
		if(health <= 0)
			Debug.Log("Health is below 0");
	}
	
}
