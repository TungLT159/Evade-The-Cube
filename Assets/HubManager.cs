using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HubManager : MonoBehaviour
{
    public Text health;
    
    public void UpdtateHealthText (float health)
    {
        this.health.text = "Health: " + health;
    }
}
