using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using TMPro;
using SimpleJSON;

public class windirectionController : MonoBehaviour
	{	
	    public GameObject textTextObject;
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
					
					int windDirection = int.Parse(weatherData["wind"]["deg"]);
					
					if(windDirection % 10 != 0) {
						windDirection = (10 - windDirection % 10) + windDirection;
					}

					Debug.Log(weatherData["wind"]["deg"]);
					switch(windDirection) {
						case 0: // N
						transform.position += new Vector3(0.0f, 0.0f, 0.10f);
						transform.Rotate(0.0f, 0.0f, 0.0f, Space.World);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "N";break;
						case 10: // N
						transform.position += new Vector3(0.0f, 0.0f, 0.10f);
						transform.Rotate(0.0f, 0.0f, 0.0f, Space.World);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "N";break;
						case 20: // N/NE
						transform.position += new Vector3(0.035f, 0.0f, 0.085f);
						transform.Rotate(0.0f, 45.0f, 0.0f, Space.World);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "N/NE";break;
						case 30: // N/NE
						transform.position += new Vector3(0.035f, 0.0f, 0.085f);
						transform.Rotate(0.0f, 45.0f, 0.0f, Space.World);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "N/NE";break;
						case 40: // NE
						transform.position += new Vector3(0.035f, 0.0f, 0.085f);
						transform.Rotate(0.0f, 45.0f, 0.0f, Space.World);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "NE";break;
						case 50: // NE
						transform.position += new Vector3(0.035f, 0.0f, 0.085f);
						transform.Rotate(0.0f, 45.0f, 0.0f, Space.World);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "NE";break;
						case 60: // E/NE
						transform.position += new Vector3(0.035f, 0.0f, 0.085f);
						transform.Rotate(0.0f, 45.0f, 0.0f, Space.World);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "E/NE";break;
						case 70: // E/NE
						transform.position += new Vector3(0.035f, 0.0f, 0.085f);
						transform.Rotate(0.0f, 45.0f, 0.0f, Space.World);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "E/NE";break;
						case 80: // E
						transform.position += new Vector3(0.05f, 0.0f, 0.05f);
						transform.Rotate(0.0f, 90.0f, 0.0f, Space.World);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "E";break;
						case 90: // E
						transform.position += new Vector3(0.05f, 0.0f, 0.05f);
						transform.Rotate(0.0f, 90.0f, 0.0f, Space.World);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "E";break;
						case 100: // E
						transform.position += new Vector3(0.05f, 0.0f, 0.05f);
						transform.Rotate(0.0f, 90.0f, 0.0f, Space.World);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "E";break;
						case 110: // E/SE
						transform.position += new Vector3(-0.036f, 0.0f, 0.012f);
						transform.Rotate(0.0f, 225.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "E/SE";break;
						case 120: // E/SE
						transform.position += new Vector3(-0.036f, 0.0f, 0.012f);
						transform.Rotate(0.0f, 225.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "E/SE";break;
						case 130: // SE
						transform.position += new Vector3(-0.036f, 0.0f, 0.012f);
						transform.Rotate(0.0f, 225.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "SE";break;
						case 140: // SE
						transform.position += new Vector3(-0.036f, 0.0f, 0.012f);
						transform.Rotate(0.0f, 225.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "SE";break;
						case 150: // S/SE
						transform.position += new Vector3(-0.036f, 0.0f, 0.012f);
						transform.Rotate(0.0f, 225.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "S/SE";break;
						case 160: // S/SE
						transform.position += new Vector3(-0.036f, 0.0f, 0.012f);
						transform.Rotate(0.0f, 225.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "S/SE";break;
						case 170: // S
						transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "S";break;
						case 180: // S
						transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "S";break;
						case 190: // S
						transform.Rotate(0.0f, 180.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "S";break;
						case 200: // S/SW
						transform.position += new Vector3(-0.035f, 0.0f, 0.012f);
						transform.Rotate(0.0f, 225.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "S/SW";break;
						case 210: // S/SW
						transform.position += new Vector3(-0.035f, 0.0f, 0.012f);
						transform.Rotate(0.0f, 225.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "S/SW";break;
						case 220: // SW
						transform.position += new Vector3(-0.035f, 0.0f, 0.012f);
						transform.Rotate(0.0f, 225.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "SW";break;
						case 230: // SW
						transform.position += new Vector3(-0.035f, 0.0f, 0.012f);
						transform.Rotate(0.0f, 225.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "SW";break;
						case 240: // W/SW
						transform.position += new Vector3(-0.035f, 0.0f, 0.012f);
						transform.Rotate(0.0f, 225.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "W/SW";break;
						case 250: // W/SW
						transform.position += new Vector3(-0.035f, 0.0f, 0.012f);
						transform.Rotate(0.0f, 225.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "W/SW";break;
						case 260: // W
						transform.position += new Vector3(-0.05f, 0.0f, 0.05f);
						transform.Rotate(0.0f, 270.0f, 0.0f, Space.World);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "W";break;
						case 270: // W
						transform.position += new Vector3(-0.05f, 0.0f, 0.05f);
						transform.Rotate(0.0f, 270.0f, 0.0f, Space.World);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "W";break;
						case 280: // W
						transform.position += new Vector3(-0.05f, 0.0f, 0.05f);
						transform.Rotate(0.0f, 270.0f, 0.0f, Space.World);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "W";break;
						case 290: // W/NW
						transform.position += new Vector3(-0.035f, 0.0f, 0.085f);
						transform.Rotate(0.0f, 315.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "W/NW";break;
						case 300: // W/NW
						transform.position += new Vector3(-0.035f, 0.0f, 0.085f);
						transform.Rotate(0.0f, 315.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "W/NW";break;
						case 310: // NW
						transform.position += new Vector3(-0.035f, 0.0f, 0.085f);
						transform.Rotate(0.0f, 315.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "NW";break;
						case 320: // NW
						transform.position += new Vector3(-0.035f, 0.0f, 0.085f);
						transform.Rotate(0.0f, 315.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "NW";break;
						case 330: // N/NW
						transform.position += new Vector3(-0.035f, 0.0f, 0.085f);
						transform.Rotate(0.0f, 315.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "N/NW";break;
						case 340: // N/NW
						transform.position += new Vector3(-0.035f, 0.0f, 0.085f);
						transform.Rotate(0.0f, 315.0f, 0.0f, Space.Self);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "N/NW";break;
						case 350: // N
						transform.position += new Vector3(0.0f, 0.0f, 0.10f);
						transform.Rotate(0.0f, 0.0f, 0.0f, Space.World);
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "N";break;
			            default:
						textTextObject.GetComponent<TextMeshPro>().text = weatherData["wind"]["speed"] + " mph " + "?";break;		                
					}
					
					float windSpeed = float.Parse(weatherData["wind"]["speed"]);
					transform.localScale += new Vector3(0,(-windSpeed)+17f,0);
					
					Debug.Log(weatherData);
					/*
		        	transform.localScale += new Vector3(0, (float.Parse(weatherData["main"]["temp"]) * 0.001f  / 3.0f - 0.006f), 0);
					transform.position += new Vector3(0, (float.Parse(weatherData["main"]["temp"]) * 0.001f / 3.0f - 0.006f), 0);
					*/
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
