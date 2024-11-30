using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    public UIplayer myPlayer;

    public GameObject canvas;

    public string getItem;

    public string replace1;
    public string replace2;

    public string searchObject;

    public bool objectFound = false;
    
    // Start is called before the first frame update
    void Start()
    {
        myPlayer = FindObjectOfType<UIplayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToPlayerInv(string item)
    {
        myPlayer.inventoryAdd(item);
    }

    public void GoToScene(string sceneName)
    {
        Debug.Log("Pressed the button!");
        SceneManager.LoadScene(sceneName);
    }

    public void GetRandomItem()
    {
        int totalItems = myPlayer.myInventory.Count;
        int finder = Random.Range(0, totalItems - 1);
        getItem = myPlayer.myInventory[finder];
    }

    public void FindItem()
    {
        if (myPlayer.myInventory.Contains(searchObject))
        {
            objectFound = true;
        }
    }

    public void ReplaceString()
    {
        canvas = GameObject.FindWithTag("canvas");
        TextMeshProUGUI currentText = canvas.transform.Find("text").GetComponent<TextMeshProUGUI>();
        GameObject currentButton = GameObject.FindWithTag("currentButton");
        currentText.text = replace1 + " " + getItem + " " + replace2;
        //canvas.transform.Find("text").GetComponent<TextMeshProUGUI>();
    }
}
