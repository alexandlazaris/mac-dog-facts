using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.UI;

public class DogApi : MonoBehaviour {
    private const string URL = "https://dog-api.kinduff.com/api/facts";

    [SerializeField]
    private Text _textObject;

    public void GenerateRequest () {
        StartCoroutine (ProcessRequest (URL));
    }

    private IEnumerator ProcessRequest (string uri) {
        using (UnityWebRequest request = UnityWebRequest.Get (uri)) {
            request.SetRequestHeader("Access-Control-Allow-Origin", "*");
            yield return request.SendWebRequest ();

            if (request.isNetworkError) {
                Debug.Log (request.error);
            } else {
                JSONNode factsResponse = JSON.Parse(request.downloadHandler.text);
                Debug.Log(factsResponse["facts"][0]);
                _textObject.text = factsResponse["facts"][0];
            }
        }
    }
}
