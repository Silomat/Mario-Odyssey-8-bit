using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Moons : MonoBehaviour
{
    public TextMeshProUGUI moonCount;
    public TextMeshProUGUI coinCount;

    public int moons;
    public int coins;

    private void Update()
    {
        
        

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Moon"))
        {
            
            moons += 1;
            Destroy(collision.gameObject);

            moonCount.text = moons.ToString() + "/20";

            //replace this comment with the code to PLAY the "Collect a moon" Sound

        } else if(collision.gameObject.CompareTag("grandMoon"))
        {
            
            moons += 3;
            Destroy(collision.gameObject);

            moonCount.text = moons.ToString() + "/20";

            //replace this comment with the code to PLAY the "Collect a Grand moon" Sound

        }
        if(collision.gameObject.CompareTag("Coin"))
        {
            coins += 1;
            Destroy(collision.gameObject);

            coinCount.text = "x" + coins.ToString();

            //replace this comment with the code to PLAY the "Collect a coin" sound

        }

    }




}
