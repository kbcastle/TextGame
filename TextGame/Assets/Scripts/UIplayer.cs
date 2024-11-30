using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIplayer : MonoBehaviour
{
    public static UIplayer Instance;

    public List<string> myInventory;

    //title screen
    public TMP_InputField myInput;
    public string playerName;
    public GameObject inputField;
    public GameObject submitButton;
   // public GameObject WelcomeObject;
   public TextMeshProUGUI WelcomeText;

    public string welcomeMessage;

    public GameObject gameStart;

  
    //public string replaceText;

    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // WelcomeText = WelcomeObject.GetComponent<TextMeshProUGUI>();
        gameStart.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void inventoryAdd(string item)
    {
        myInventory.Add(item);
    }

    public void SetName()
    {
        playerName = myInput.text;

        inputField.SetActive(false);
        submitButton.SetActive(false);
        gameStart.SetActive(true);

        //string newWelcome = welcomeMessage.Replace(replaceText, playerName);
        WelcomeText.text = welcomeMessage + playerName;
    }


}
