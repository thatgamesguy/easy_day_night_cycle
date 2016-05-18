using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent (typeof(Slider))]
public class CurrentTimeSlider : MonoBehaviour
{
	public DayNightController Controller;
	private Slider _slider;

	// Use this for initialization
	void Awake ()
	{
		_slider = GetComponent<Slider> ();
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
		_slider.value = Controller.CurrentTimeOfDay;
	}
}
