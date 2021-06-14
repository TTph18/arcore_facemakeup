using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;


public class CameraSample : MonoBehaviour
{
	Button Capture;
	bool takePicture;

	void Update()
	{
		Capture.GetComponent<Button>().onClick.AddListener(delegate { CaptureClicked(); });
	}

   // private void OnRenderImage(RenderTexture source, RenderTexture destination)
   // {
   //     if(takePicture)
   //     {
			//takePicture = false;

			//var tempRend = RenderTexture.GetTemporary(source.width, source.height);
			//Graphics.Blit(source, tempRend);

			//Texture2D tempText = new Texture2D(source.width, source.height, TextureFormat.RGBA32, false);
			//Rect rect = new Rect(0, 0, source.width, source.height);
			//tempText.ReadPixels(rect, 0, 0, false);
			//tempText.Apply();
   //     }
   // }

    public void CaptureClicked()
    {
		StartCoroutine(TakeScreenshotAndSave());
	}

	private IEnumerator TakeScreenshotAndSave()
	{
		yield return new WaitForEndOfFrame();

		Texture2D ss = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
		ss.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
		ss.Apply();

		// Save the screenshot to Gallery/Photos
		NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(ss, "GalleryTest", "Image.png", (success, path) => Debug.Log("Media save result: " + success + " " + path));

		Debug.Log("Permission result: " + permission);

		// To avoid memory leaks
		Destroy(ss);
	}

}
