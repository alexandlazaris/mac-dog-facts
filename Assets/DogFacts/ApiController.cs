using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class ApiController : MonoBehaviour {

    string url = "https://dog-api.kinduff.com/api/facts";

    [SerializeField]
    Text textObject = null;

    [Serializable]
    public class JsonResponse {
        public List<string> facts;
    }

    [SerializeField]
    String fact = "";

    void Start () {
        // StartCoroutine (callApi ());
    }

    IEnumerator callApi () {
        UnityWebRequest uwr = UnityWebRequest.Get (url);
        yield return uwr.SendWebRequest ();
        if (uwr.isHttpError) {
            Debug.Log ("Error While Sending: " + uwr.error);
        } else {
            // Debug.Log ("Received: " + uwr.downloadHandler.text);
            // JsonResponse info = JsonUtility.FromJson<JsonResponse> (uwr.downloadHandler.text);
            // Debug.Log (info.facts[0]);
        }
        JsonResponse info = JsonUtility.FromJson<JsonResponse> (uwr.downloadHandler.text);
        Debug.Log (info.facts[0]);
        textObject.text = info.facts[0];
        fact = info.facts[0];
    }
}
