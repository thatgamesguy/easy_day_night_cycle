using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[System.Serializable]
public struct WorldTime
{
	[Range (0, 24)]
	public int
		Hours;
		 
	[Range (0, 60)]
	public int
		Minutes;
	
	public void SetTime (int hours, int minutes)
	{
		this.Hours = Mathf.Clamp (hours, 0, 24);
		this.Minutes = Mathf.Clamp (minutes, 0, 60);
	}
	
	public override string ToString ()
	{
		return string.Format ("{0}:{1}", Hours.ToString ("00"), Minutes.ToString ("00"));
	}
	

}