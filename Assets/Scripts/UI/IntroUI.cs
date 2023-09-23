using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroUI : MonoBehaviour
{
    [SerializeField] private Button startBtn;
    [SerializeField] private Button OptionsBtn;
    [SerializeField] private Button QuitBtn;
    [SerializeField] private Button BackBtn;
    [SerializeField] private Button AgreeBtn;


    [SerializeField] private GameObject OptionsPanel;

    private void Awake()
    {
        startBtn.onClick.AddListener(OnClickStartBtn);
        OptionsBtn.onClick.AddListener(OnUiBtn);
        QuitBtn.onClick.AddListener(OnClickQuitBtn);
        BackBtn.onClick.AddListener(OnClickBackBtn);
        AgreeBtn.onClick.AddListener(OnClickQuitBtn);
    }


    private void OnClickStartBtn()
    {
        SceneManager.LoadScene("TutorialScene");
    }
    
    private void OnClickOptionsBtn()
    {
        
    }
    
    private void OnClickQuitBtn()
    {
        Application.Quit();
    }

    private void OnClickBackBtn()
    {
        OptionsPanel.SetActive(false);
    }

    private void OnClickAgreeBtn()
    {
        OptionsPanel.SetActive(false);
    }

    private void OnUiBtn()
    {
        OptionsPanel.SetActive(true);
    }
    
    private void OffUiBtn()
    {
        
    }
}
