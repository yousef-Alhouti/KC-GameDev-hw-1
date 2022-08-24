using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHeath : MonoBehaviour
{
    int health = 100;
    string hero;
    int damaged = 20;
    int boost = 10;
    int damagedhealth = 80;
    int boostedhealth = 90;
    // Start is called before the first frame update
    void Start()
    {
        print(health - damaged);
        print(damagedhealth + boost);

        if(damagedhealth > boostedhealth)
        {
            print("damaged health is more than boosted health");
        }
        else if (damagedhealth == boostedhealth)
        {
            print("damaged health is the same as boosted health");
        }
        else
        {
            print("boosted health is more than damaged health");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
