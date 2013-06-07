// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.
using UnityEngine;
using System.Collections;

public class SoundToggler_CSharp : MonoBehaviour
{
	public float fadeTime = 1.0f;
	private SoundController_CSharp soundScript;

	void  Start ()
	{ 
		soundScript = FindObjectOfType (typeof(SoundController_CSharp)) as SoundController_CSharp; 
	}

	void  OnTriggerEnter ()
	{ 
		soundScript.ControlSound (true, fadeTime); 
	}

	void  OnTriggerExit ()
	{ 
		soundScript.ControlSound (false, fadeTime); 
	}
}