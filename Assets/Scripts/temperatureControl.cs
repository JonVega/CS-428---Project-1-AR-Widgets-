using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using SimpleJSON;

public class temperatureControl : MonoBehaviour
	{	
	    public GameObject tempTextObject;
		string url = "http://api.openweathermap.org/data/2.5/weather?lat=41.88&lon=-87.6&APPID=da93369bfa44d34009b876ec8346a3ac&units=imperial";

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GetDataFromWeb", 0f, 30f);
    }
	
	void GetDataFromWeb()
	   {
	       StartCoroutine(GetRequest(url));
	   }

	    IEnumerator GetRequest(string uri)
	    {
	        using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
	        {
	            // Request and wait for the desired page.
	            yield return webRequest.SendWebRequest();

	            if (webRequest.isNetworkError)
	            {
	                Debug.Log(": Error: " + webRequest.error);
	            }
	            else
	            {
	                // print out the weather data to make sure it makes sense
	                //Debug.Log(":\nReceived: " + webRequest.downloadHandler.text);

					JSONNode weatherData = JSON.Parse(webRequest.downloadHandler.text);
					Debug.Log(weatherData);
					tempTextObject.GetComponent<TextMeshPro>().text = weatherData["main"]["temp"] + "F";
					
					
	            }
	        }
	    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("t")) {
        	transform.localScale += new Vector3(0, 0.001f, 0);
			transform.position += new Vector3(0, 0.001f, 0);
        }
    }
}
