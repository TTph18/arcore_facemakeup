using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class FaceSwap : MonoBehaviour
{
    private ARFaceManager faceManager;
    public List<Material> faceMaterials;
    private int faceMaterialIndex = 0;
    private void Start()
    {
        faceManager = GetComponent<ARFaceManager>();
    }
    public void SwitchCheek1()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[1];
        }
        //faceMaterialIndex++;
        //if (faceMaterialIndex == faceMaterials.Count)
        //{
        //    faceMaterialIndex = 0;
        //}
    }
    public void SwitchCheek2()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[2];
        }
    }
    public void SwitchCheek3()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[3];
        }
    }
    public void SwitchCheek4()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[4];
        }
    }
    public void SwitchCheek5()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[5];
        }
    }
    public void SwitchEyeshadow1()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[6];
        }
    }
    public void SwitchEyeliner1()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[7];
        }
    }
    public void SwitchEyeliner2()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[8];
        }
    }
    public void SwitchLip1()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[9];
        }
    }
    public void SwitchLip2()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[10];
        }
    }
    public void SwitchLip3()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[11];
        }
    }
    public void SwitchLip4()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[12];
        }
    }
    public void SwitchTattoo1()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[13];
        }
    }
    public void SwitchTattoo2()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[14];
        }
    }
    public void SwitchTattoo3()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[15];
        }
    }
    public void SwitchTattoo4()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[16];
        }
    }
    public void SwitchTattoo5()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[17];
        }
    }
    public void SwitchEyeshadow2()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[18];
        }
    }
    public void SwitchEyeshadow3()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[19];
        }
    }
    public void SwitchEyeshadow4()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[20];
        }
    }
    public void SwitchEyeshadow5()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[21];
        }
    }
    public void SwitchEyeliner3()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[22];
        }
    }
    public void SwitchFullMakeup1()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[23];
        }
    }
    public void SwitchFullMakeup2()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<MeshRenderer>().material = faceMaterials[24];
        }
    }
}
