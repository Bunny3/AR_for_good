using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class TestPlugin : MonoBehaviour {
    public RobotController RobotControllerobj;
	AndroidJavaClass jc;
    //public AudioSource jump, rage;
    public string[] keywords = new string[] { "up", "down", "left", "right" };

    // Use this for initialization
    void Start () {  


	}
    void Update()
    {
        
    }

    public void OnButtonClick()
	{
		var go = EventSystem.current.currentSelectedGameObject;
		if (go != null) {
			Debug.Log ("Clicked on : " + go.name);
		#if UNITY_ANDROID
			jc = new AndroidJavaClass("com.example.speechassist.Assist");
			jc.CallStatic("promptSpeechInput");
		#endif
		} else {
			Debug.Log ("currentSelectedGameObject is null");
		}
	}

	void onActivityResult(string Translation){
	
		Debug.Log (Translation);
		GameObject.Find ("TextRecognition").GetComponent<UnityEngine.UI.Text> ().text = Translation;
        /*int result = string.CompareOrdinal(Translation,"jump");
        if (result == 0)
        {
            jump.Play();
        }
        result = string.CompareOrdinal(Translation, "rage");
        if (result == 0)
        {
            rage.Play();
        }*/
        RobotControllerobj.RobotActions(Translation);
    }
}
