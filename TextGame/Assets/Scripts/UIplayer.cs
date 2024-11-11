using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIplayer : MonoBehaviour
{
    public static UIplayer Instance;

    public List<string> myInventory;


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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void inventoryAdd(string item)
    {
        myInventory.Add(item);
    }
}
