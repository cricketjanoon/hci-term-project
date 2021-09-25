using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public GameObject[] panels;
    public GameObject[] activeButton;
    public GameObject mainMenuPanel;
    public Animator mainMenuAnimator;
    public Animator rateUsAnimator;

    public GameObject rateUsPanel;

    public AudioSource audioSource;

    public bool isMainMenuOpen = true;
    public InputField username,
        password;
    public Text loginFailedText;

    // Use this for initialization
    void Start()
    {
        loginFailedText.text = "";
        mainMenuAnimator = mainMenuPanel.GetComponent<Animator>();

        for (int i = 0; i < activeButton.Length; i++)
        {
            activeButton[i].SetActive(false);
        }

        activeButton[0].SetActive(true);
        rateUsPanel.SetActive(false);
        //audioSource.GetComponent<AudioSource>();
    }

    public void ShowPanel(int index)
    {
        audioSource.Play();

        if (index < 0 && index > panels.Length - 1)
        {
            Debug.Log("UIManager: Invalid index for panel array.");
            return;
        }

        for (int i = 0; i < panels.Length; i++)
        {
            panels[i].gameObject.SetActive(false);
            activeButton[i].SetActive(false);
        }


        panels[index].SetActive(true);
        activeButton[index].SetActive(true);


    }

    public void ManageMainMenu()
    {

        if (isMainMenuOpen)
        {
            mainMenuAnimator.SetTrigger("HideMenu");

        }
        else
        {
            mainMenuAnimator.SetTrigger("ShowMenu");
        }

        isMainMenuOpen = !isMainMenuOpen;

    }

    public void LogIn()
    {
        if (username.text == "cricketjanoon" && password.text == "123456")
        {
            Debug.Log("You are logged-in.");
            loginFailedText.text = "<color='green'>You are now logged-in.</color>";
        }
        else
            loginFailedText.text = "Please enter valid cradentials.";
    }
    /// <summary>
    /// /Mehtods to implement
    /// </summary>
    public void RateUs()
    {
        rateUsPanel.SetActive(true);
        audioSource.Play();

    }

    public void Submit()
    {
        audioSource.Play();
        rateUsAnimator.SetTrigger("SubmitRatting");
        rateUsPanel.SetActive(false);
    }

    public void NewGame()
    {
        audioSource.Play();
    }

    public void Resume()
    {
        audioSource.Play();
    }
    public void Exit()
    {
        audioSource.Play();
    }


}
