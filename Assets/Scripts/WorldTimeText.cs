using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(Text))]
public class WorldTimeText : MonoBehaviour
{
	public DayNightController Controller;
	private Text _text;
	
	// Use this for initialization
	void Awake ()
	{
		_text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		_text.text = Controller.LocalTime.ToString ();
	}
}
