using System;
using UnityEditor.SearchService;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChoiceDialog : MonoBehaviour
{
    public GameObject dialogPanel;
    public Text messageText;
    public Button YesButton;
    public Button NoButton;
    public string sceneToLoad;
    bool isPlayer = false;
    private bool hasKey = false;
    void Start()
    {
        dialogPanel.SetActive(false);

        YesButton.onClick.AddListener(OnYesClicked);
        NoButton.onClick.AddListener(OnNoClicked);
    }

    void Update()
    {
        if(isPlayer && Input.GetKeyDown(KeyCode.F))
        {
            Showdialog();
        }
    }

    public void Showdialog()
    {
        dialogPanel.SetActive(true);
        messageText.text = "ไปมั้ย";
    }

    void OnYesClicked()
    {
        // if (hasKey)
        // {
        //     SceneManager.LoadScene();
        // }
        // else
        // {
            
        // }
    }

    void OnNoClicked()
    {
        dialogPanel.SetActive(false);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Player");
            isPlayer = true;
        } 
    }


    void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            isPlayer = false;
        }
    }
    public void PickupKey()
    {
        hasKey = true;
    }
}
