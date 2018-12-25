using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_canvas : MonoBehaviour {
    public int [] numSlots;
    public GameObject [] SlotPlayer;
    public GameObject Slots;


    void Awake()
    {
        numSlots = GameObject.Find("BattleManager").GetComponent<BattleManager>().numPlayers;
            
    }

    // Update is called once per frame
    void Start()
    {
        
        for (int x = 0; x< numSlots; x++)
        {
            GameObject Slots = Instantiate as GameObject;
            numSlots[x] = Slots;
            
        }
    }
}
