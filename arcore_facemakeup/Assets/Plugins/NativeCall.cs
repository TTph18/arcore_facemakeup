using System;
using UnityEngine;


public static class NativeCall
{
    #region OpenPhoto

    public static void OpenPhoto(Action<Texture2D> callBack)
    {
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((string path) =>
        {
            if (!string.IsNullOrEmpty(path) && callBack != null)
            {
                callBack(NativeGallery.LoadImageAtPath(path));
            }
        });
        if (permission != NativeGallery.Permission.Granted)
        {
            if (NativeGallery.CanOpenSettings()) NativeGallery.OpenSettings();
        }
    }

    public static void OpenPhoto(Action<string> callBack)
    {
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((string path) =>
        {
            if (!string.IsNullOrEmpty(path) && callBack != null)
            {
                callBack(path);
            }
        });
        if (permission != NativeGallery.Permission.Granted)
        {
            if (NativeGallery.CanOpenSettings()) NativeGallery.OpenSettings();
        }
    }

    public static void OpenPhotos(Action<Texture2D[]> callBack)
    {
        NativeGallery.Permission permission = NativeGallery.GetImagesFromGallery((string[] path) =>
        {
            if (path == null || path.Length == 0) return;
            Texture2D[] texs = new Texture2D[path.Length];
            for (int i = 0; i < path.Length; i++)
            {
                try
                {
                    if (!string.IsNullOrEmpty(path[i]))
                        texs[i] = NativeGallery.LoadImageAtPath(path[i]);
                }
                catch (Exception ex) { Debug.LogWarning("第" + i + "张图片处理失败 : " + ex.Message + "\n" + path[i]); }
            }
            if (callBack != null) callBack(texs);
        });
        if (permission != NativeGallery.Permission.Granted)
        {
            if (NativeGallery.CanOpenSettings()) NativeGallery.OpenSettings();
        }
    }

    public static void OpenPhotos(Action<string[]> callBack)
    {
        NativeGallery.Permission permission = NativeGallery.GetImagesFromGallery((string[] path) =>
        {
            if (path == null || path.Length == 0) return;
            if (callBack != null) callBack(path);
        });
        if (permission != NativeGallery.Permission.Granted)
        {
            if (NativeGallery.CanOpenSettings()) NativeGallery.OpenSettings();
        }
    }
    #endregion

    #region OpenVideo
    public static void OpenVideo(Action<string> callBack)
    {
        NativeGallery.Permission permission = NativeGallery.GetVideoFromGallery((string path) =>
        {
            if (!string.IsNullOrEmpty(path) && callBack != null) callBack(path);
        });
        if (permission != NativeGallery.Permission.Granted)
        {
            if (NativeGallery.CanOpenSettings()) NativeGallery.OpenSettings();
        }
    }

    public static void OpenVideo(Action<string[]> callBack)
    {
        NativeGallery.Permission permission = NativeGallery.GetVideosFromGallery((string[] path) =>
        {
            if (path == null || path.Length == 0) return;
            if (callBack != null) callBack(path);
        });
        if (permission != NativeGallery.Permission.Granted)
        {
            if (NativeGallery.CanOpenSettings()) NativeGallery.OpenSettings();
        }
    }
    #endregion

    #region OpenCamera

    public static void OpenCamera(Action<Texture2D> callBack)
    {
        NativeCamera.Permission permission = NativeCamera.TakePicture((string path) =>
        {
            if (!string.IsNullOrEmpty(path) && callBack != null)
                callBack(NativeCamera.LoadImageAtPath(path));
        });
        if (permission != NativeCamera.Permission.Granted)
        {
            if (NativeCamera.CanOpenSettings()) NativeCamera.OpenSettings();
        }
    }

    public static void OpenCamera(Action<string> callBack)
    {
        NativeCamera.Permission permission = NativeCamera.TakePicture((string path) =>
        {
            if (!string.IsNullOrEmpty(path) && callBack != null)
                callBack(path);
        });
        if (permission != NativeCamera.Permission.Granted)
        {
            if (NativeCamera.CanOpenSettings()) NativeCamera.OpenSettings();
        }
    }

    public static void OpenCameraVideo(Action<string> callBack)
    {
        NativeCamera.Permission permission = NativeCamera.RecordVideo((string path) =>
        {
            if (!string.IsNullOrEmpty(path) && callBack != null)
                callBack(path);
        });
        if (permission != NativeCamera.Permission.Granted)
        {
            if (NativeCamera.CanOpenSettings()) NativeCamera.OpenSettings();
        }
    }
    #endregion

    #region SavePhoto
    public static void SavePhoto(Texture2D tex, Action<bool> callBack = null)
    {
        try
        {
            NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(tex, Application.productName, DateTime.Now.ToFileTime() + ".jpg", ( success, path ) => Debug.Log( "Media save result: " + success + " " + path ) );
	        Debug.Log( "Permission result: " + permission );
            
            if (permission != NativeGallery.Permission.Granted)
            {
                ShowToast("保存图片失败 : 没有权限");
                if (NativeGallery.CanOpenSettings()) NativeGallery.OpenSettings();

                if (callBack != null) callBack(false);
            }
        }
        catch (Exception ex)
        {
            ShowToast("保存图片失败 : " + ex.Message);

            if (callBack != null) callBack(false);
        }
    }

    public static void SavePhoto(string path, Action<bool> callBack = null)
    {
        try
        {
            NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(path, Application.productName, DateTime.Now.ToFileTime() + ".jpg", ( success, path ) => Debug.Log( "Media save result: " + success + " " + path ) );
	        Debug.Log( "Permission result: " + permission );
            if (permission != NativeGallery.Permission.Granted)
            {
                ShowToast("保存图片失败 : 没有权限");
                if (NativeGallery.CanOpenSettings()) NativeGallery.OpenSettings();

                if (callBack != null) callBack(false);
            }
        }
        catch (Exception ex)
        {
            ShowToast("保存图片失败 : " + ex.Message);

            if (callBack != null) callBack(false);
        }
    }

    public static void SavePhoto(byte[] data, Action<bool> callBack = null)
    {
        try
        {
            NativeGallery.Permission permission = NativeGallery.SaveImageToGallery(data, Application.productName, DateTime.Now.ToFileTime() + ".jpg", ( success, path ) => Debug.Log( "Media save result: " + success + " " + path ) );
	        Debug.Log( "Permission result: " + permission );
            if (permission != NativeGallery.Permission.Granted)
            {
                ShowToast("保存图片失败 : 没有权限");

                if (NativeGallery.CanOpenSettings()) NativeGallery.OpenSettings();

                if (callBack != null) callBack(false);
            }
        }
        catch (Exception ex)
        {
            ShowToast("保存图片失败 : " + ex.Message);

            if (callBack != null) callBack(false);
        }
    }
    #endregion

    #region 显示一个Toast

#if !UNITY_EDITOR && UNITY_IOS
    [System.Runtime.InteropServices.DllImport("__Internal")]
    private static extern void _showDialog(string msg);
#endif


    public static void ShowToast(string msg)
    {
        if (msg == "") msg = "empty";
        else if (msg == null) msg = "null";
#if UNITY_EDITOR
        Debug.Log("Toast:" + msg);
#elif UNITY_ANDROID
        //拿到Activity
        AndroidJavaObject currentActivity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
        AndroidJavaClass Toast = new AndroidJavaClass("android.widget.Toast");
        currentActivity.Call("runOnUiThread", new AndroidJavaRunnable(() =>
        {
            AndroidJavaObject javaString = new AndroidJavaObject("java.lang.String", msg);
            Toast.CallStatic<AndroidJavaObject>("makeText", currentActivity, javaString, Toast.GetStatic<int>("LENGTH_SHORT")).Call("show");
        }
        ));
#elif UNITY_IOS
        _showDialog(msg);
#endif
    }
    #endregion

}
