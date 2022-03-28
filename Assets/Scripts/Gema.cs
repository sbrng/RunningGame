using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gema : MonoBehaviour
{
    public Player player;
    public GameObject gema;
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.tag == "Borders")
        {
            Debug.Log("gema collision");
            Destroy(this.gema);
        }

        else if(collision.tag == "Player")
        {
            Debug.Log("new gema");
            player.incrementGema();
            Destroy(this.gema);
            Debug.Log("new gema");
        }
    }
}
