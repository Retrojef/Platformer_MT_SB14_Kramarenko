using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class OpenChest : MonoBehaviour
{
    
    public GameObject OpenedChest;
    public GameObject Gem;
    void OnTriggerEnter2D(Collider2D other)
    {
         if(other.CompareTag("Player"))
         {
            gameObject.SetActive(false);
            Instantiate(OpenedChest, transform.position, Quaternion.identity);
            Instantiate(Gem, transform.position, Quaternion.identity);
            GameObject.Find("Character").GetComponent<ScoreText>().UpdateUI();
         }
    }
}
