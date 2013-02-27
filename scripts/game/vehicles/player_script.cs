using UnityEngine;
using System.Collections;

public class player_script : MonoBehaviour
{
	
	public static string forward_keymain = "W";
	public static string left_keymain = "A";
	public static string right_keymain = "D";
	public static string back_keymain = "S";
	public static string forward_keyalt = "Up";
	public static string left_keyalt = "Left";
	public static string right_keyalt = "Right";
	public static string back_keyalt = "Back";
	public static string shiftup_keymain = "Left Shift";
	public static string shiftdown_keymain = "Left Control";
	public static string shiftup_keyalt = "Right Shift";
	public static string shiftdown_keyalt = "Right Control";
	public static string gear_string;
	public static bool isManual;
	public static bool gear1;
	public static bool gear2;
	public static bool gear3;
	public static bool gear4;
	public static bool gear5;
	public static bool neutral;
	public static bool reverse;
	public int condition_engine = 100;
	public int condition_transmission = 100;
	public int condition_tire1 = 100;
	public int condition_tire2 = 100;
	public int condition_tire3 = 100;
	public int condition_tire4 = 100;
	public int ammount_gas = 100;
	public int ammount_oil = 100;
	public int counter_speed = 0;
	public int counter_revs = 0;

	//Use this for initialization
	void Start ()
	{
		isManual = true;
		gear1 = true;
		gear2 = false;
		gear3 = false;
		gear4 = false;
		gear5 = false;
		neutral = false;
		reverse = false;
	}
	
	void gearup ()
	{
		
	}
	
	void damager ()
	{
		//collides with front. remove hood. engine damage causes oil to leak. no oil causes quicker death.
		//collides with left_side. remove doors
		//collides with right side.remove doors
		//collides with rear.remove trunk
		//upside down.create boolean for upside damagers.
		//If upside damage until it blows up or automatically flips over to prevent damage
	}
	
	void geardown ()
	{
		
	}
	
	void manualshift ()
	{
		
	}
	
	void automaticshift ()
	{
		
	}

	void playercontrols ()
	{
		if (Input.GetKey (forward_keymain) || Input.GetKey (forward_keyalt)) {
			//forward	
		}
		if (Input.GetKey (left_keymain) || Input.GetKey (left_keyalt)) {
			//left	
		}
		if (Input.GetKey (right_keymain) || Input.GetKey (right_keyalt)) {
			//right	
		}
		if (Input.GetKey (back_keymain) || Input.GetKey (back_keyalt)) {
			//back	
		}
		if (Input.GetKey (shiftup_keymain) || Input.GetKey (shiftup_keyalt)) {
			//back	
		}
		if (Input.GetKey (shiftdown_keymain) || Input.GetKey (shiftdown_keyalt)) {
			//back	
		}
	}
	// Update is called once per frame
	void Update ()
	{
	
	}
}
