using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Processing : MonoBehaviour
{
    public GameObject MainPanel;
    public GameObject MakeupPanel;
    public GameObject EffectPanel;
    public GameObject FilterPanel;
    public GameObject MakeUpShadow;
    public GameObject MakeUpBlusher;
    public GameObject MakeUpTattoo;
    public GameObject MakeUpEyeLine;
    public GameObject MakeUpLip;
    public List<GameObject> list = new List<GameObject>();
    public void MakeList()
    {
        list.Add(MainPanel);
        list.Add(MakeupPanel);
        list.Add(EffectPanel);
        list.Add(FilterPanel);

        list.Add(MakeUpShadow);
        list.Add(MakeUpBlusher);
        list.Add(MakeUpTattoo);
        list.Add(MakeUpEyeLine);
        list.Add(MakeUpLip);
    }
    public void OpenMakeupPanel()
    {
        list.Clear();
        MakeList();
        if (MakeupPanel != null)
            MakeupPanel.SetActive(true);
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != MakeupPanel && list[i] != null)
                list[i].SetActive(false);
        }
        /*MainPanel.SetActive(false);
        EffectPanel.SetActive(true);
        FilterPanel.SetActive(false);*/
    }
    public void OpenEffectPanel()
    {
        if (EffectPanel != null)
            EffectPanel.SetActive(true);
        MakeupPanel.SetActive(false);
        FilterPanel.SetActive(false);
        MainPanel.SetActive(false);
    }
    public void OpenAlbumPanel()
    {
        EffectPanel.SetActive(false);
        MakeupPanel.SetActive(false);
        FilterPanel.SetActive(false);
        MainPanel.SetActive(false);
    }
    public void OpenFilterPanel()
    {
        MainPanel.SetActive(false);
        EffectPanel.SetActive(false);
        MakeupPanel.SetActive(false);
        if (FilterPanel != null)
            FilterPanel.SetActive(true);
    }
    public void OpenMainPanel()
    {
        if (MainPanel != null)
            MainPanel.SetActive(true);
        FilterPanel.SetActive(false);
        EffectPanel.SetActive(false);
        MakeupPanel.SetActive(false);
    }

    public void ReturnMakeupPanel()
    {
        if (MakeupPanel != null)
            MakeupPanel.SetActive(true);
        MakeUpBlusher.SetActive(false);
        MakeUpEyeLine.SetActive(false);
        MakeUpLip.SetActive(false);
        MakeUpShadow.SetActive(false);
        MakeUpTattoo.SetActive(false);
    }
    public void OpenMakeupBlusher()
    {
        list.Clear();
        MakeList();
        if (MakeUpBlusher != null)
            MakeUpBlusher.SetActive(true);
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != MakeUpBlusher && list[i] != null)
                list[i].SetActive(false);
        }
        /*MainPanel.SetActive(false);
        EffectPanel.SetActive(true);
        FilterPanel.SetActive(false);*/
    }
    public void OpenMakeupLip()
    {
        list.Clear();
        MakeList();
        if (MakeUpLip != null)
            MakeUpLip.SetActive(true);
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != MakeUpLip && list[i] != null)
                list[i].SetActive(false);
        }
        /*MainPanel.SetActive(false);
        EffectPanel.SetActive(true);
        FilterPanel.SetActive(false);*/
    }
    public void OpenMakeupEyeLine()
    {
        list.Clear();
        MakeList();
        if (MakeUpEyeLine != null)
            MakeUpEyeLine.SetActive(true);
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != MakeUpEyeLine && list[i] != null)
                list[i].SetActive(false);
        }
        /*MainPanel.SetActive(false);
        EffectPanel.SetActive(true);
        FilterPanel.SetActive(false);*/
    }
    public void OpenMakeupShadow()
    {
        list.Clear();
        MakeList();
        if (MakeUpShadow != null)
            MakeUpShadow.SetActive(true);
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != MakeUpShadow && list[i] != null)
                list[i].SetActive(false);
        }
        /*MainPanel.SetActive(false);
        EffectPanel.SetActive(true);
        FilterPanel.SetActive(false);*/
    }
    public void OpenMakeupTattoo()
    {
        list.Clear();
        MakeList();
        if (MakeUpTattoo != null)
            MakeUpTattoo.SetActive(true);
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] != MakeUpTattoo && list[i] != null)
                list[i].SetActive(false);
        }
        /*MainPanel.SetActive(false);
        EffectPanel.SetActive(true);
        FilterPanel.SetActive(false);*/
    }
}
