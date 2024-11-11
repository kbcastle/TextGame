using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{

    public UIplayer myPlayer;

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
}
