using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Processing : MonoBehaviour
{
    public GameObject MainPanel;
    public GameObject MakeupPanel;
    public GameObject EffectPanel;
    public GameObject AlbumPanel;
    public GameObject FilterPanel;

    public void OpenMakeupPanel()
    {
        if (MakeupPanel != null)
            MakeupPanel.SetActive(true);
        MainPanel.SetActive(false);
        EffectPanel.SetActive(true);
        AlbumPanel.SetActive(false);
        FilterPanel.SetActive(false);
    }
    public void OpenEffectPanel()
    {
        if (EffectPanel != null)
            EffectPanel.SetActive(true);
        MakeupPanel.SetActive(false);
        AlbumPanel.SetActive(false);
        FilterPanel.SetActive(false);
        MainPanel.SetActive(false);
    }
    public void OpenAlbumPanel()
    {
        EffectPanel.SetActive(false);
        MakeupPanel.SetActive(false);
        AlbumPanel.SetActive(false);
        if (AlbumPanel != null)
            AlbumPanel.SetActive(true);
        FilterPanel.SetActive(false);
        MainPanel.SetActive(false);
    }
    public void OpenFilterPanel()
    {
        MainPanel.SetActive(false);
        EffectPanel.SetActive(false);
        MakeupPanel.SetActive(false);
        AlbumPanel.SetActive(false);
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
        AlbumPanel.SetActive(false);
        
    }
}
