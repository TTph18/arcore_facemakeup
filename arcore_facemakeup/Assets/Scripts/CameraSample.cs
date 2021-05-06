using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;


public class CameraSample : MonoBehaviour
{
	Button Capture;
	void Update()
	{
		Capture.GetComponent<Button>().onClick.AddListener(delegate { captureClicked(); });
	}

	public void captureClicked()
    {
        if (NativeCamera.IsCameraBusy())
				return;

			if (Input.mousePosition.x < Screen.width / 2)
			{
				// Take a picture with the camera
				// If the captured image's width and/or height is greater than 512px, down-scale it
				TakePicture(512);
			}
    }

	private void TakePicture(int maxSize)
	{
		NativeCamera.Permission permission = NativeCamera.TakePicture((path) =>
		{
			Debug.Log("Image path: " + path);
			if (path != null)
			{
				// Create a Texture2D from the captured image
				Texture2D texture = NativeCamera.LoadImageAtPath(path, maxSize);
				if (texture == null)
				{
					Debug.Log("Couldn't load texture from " + path);
					return;
				}

				// Assign texture to a temporary quad and destroy it after 5 seconds
				GameObject quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
				quad.transform.position = Camera.main.transform.position + Camera.main.transform.forward * 2.5f;
				quad.transform.forward = Camera.main.transform.forward;
				quad.transform.localScale = new Vector3(1f, texture.height / (float)texture.width, 1f);

				Material material = quad.GetComponent<Renderer>().material;
				if (!material.shader.isSupported) // happens when Standard shader is not included in the build
					material.shader = Shader.Find("Legacy Shaders/Diffuse");

				material.mainTexture = texture;
				NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(texture, Application.productName, DateTime.Now.ToFileTime() + ".jpg", (success, path) => Debug.Log("Media save result: " + success + " " + path));
				Debug.Log("Permission result: " + permission);
				Destroy(quad, 5f);

				// If a procedural texture is not destroyed manually, 
				// it will only be freed after a scene change
				Destroy(texture, 5f);
			}
		}, maxSize);

		Debug.Log("Permission result: " + permission);
	}

}
