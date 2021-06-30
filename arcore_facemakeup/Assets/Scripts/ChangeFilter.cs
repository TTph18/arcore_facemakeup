using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

namespace Assets.Scripts
{
    class ChangeFilter : MonoBehaviour
    {
        public GameObject BrightVolume;
        public GameObject ContrastVolume;
        public GameObject OldVolume;
        public GameObject WarmVolume;
        public List<GameObject> list = new List<GameObject>();

        public void MakeList()
        {
            list.Add(BrightVolume);
            list.Add(ContrastVolume);
            list.Add(OldVolume);
            list.Add(WarmVolume);
        }
        public void ChangeBright()
        {
            list.Clear();
            MakeList();
            BrightVolume.SetActive(true);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != BrightVolume && list[i] != null)
                    list[i].SetActive(false);
            }
        }
        public void ChangeContrast()
        {
            list.Clear();
            MakeList();
            ContrastVolume.SetActive(true);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != ContrastVolume && list[i] != null)
                    list[i].SetActive(false);
            }
        }
        public void ChangeOld()
        {
            list.Clear();
            MakeList();
            OldVolume.SetActive(true);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != OldVolume && list[i] != null)
                    list[i].SetActive(false);
            }
        }
        public void ChangeWarm()
        {
            list.Clear();
            MakeList();
            WarmVolume.SetActive(true);
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] != WarmVolume && list[i] != null)
                    list[i].SetActive(false);
            }
        }
        public void DisableAll()
        {
            list.Clear();
            MakeList();
            for (int i = 0; i < list.Count; i++)
            {
                list[i].SetActive(false);
            }
        }
    }
}
