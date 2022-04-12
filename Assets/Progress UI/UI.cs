using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using EasyUI.Progress;
public class UI : MonoBehaviour
{
    [SerializeField]
    [TextArea]
    private string imgUrl;

    [SerializeField] RawImage img;

    private void Start()
    {
        Progress.Show("Loading.. ", ProgressColor.Green, true);
        
        StartCoroutine(Load());
    }
    IEnumerator Load()
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(imgUrl);
        request.SendWebRequest();
        while (!request.isDone)
        {
            float progress = request.downloadProgress * 100f;
            Progress.SetProgressValue(progress);
            yield return null;

        }
        if(request.result == UnityWebRequest.Result.Success)
        {
            Debug.Log("Completed");
            Progress.Hide();
            img.texture = DownloadHandlerTexture.GetContent(request);
        }

    }

}
