using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;


	void Start () 
	{
		StartGame();
	}

	void StartGame ()
	{
		max = 1000;
		min = 1;
		guess = 500;

		print("===================================");

		print("Welcome to Number Wizard");
		print("Pick a number in your head but don't tell me!");

		print("The highest number you can pick is " + max);
		max += 1;
		print("The lowest number you can pick is " + min);

		print("Is the number higher than lower than " + guess);
		print("Up = higher, Down = lower, Return = equal");
	}


	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			// print ("Down was pressed");
			max = guess;
			nextGuess ();

		} 
		else if (Input.GetKeyDown (KeyCode.UpArrow)) {
			// print ("Up was pressed");
			min = guess;
			nextGuess();
		} 
		else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("I won!");
			StartGame ();
		}
	}

	void nextGuess ()
	{
		guess = (max + min) / 2;
		print ("Higher or Lower than " + guess);
		print("Up = higher, Down = lower, Return = equal");
	}
}
