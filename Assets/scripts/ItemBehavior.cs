using UnityEngine;

public class ItemBehavior : MonoBehaviour 
 {
     public GameBehavior gameManager;
 
     void Start()
     {               
           gameManager = GameObject.Find("GameManager").GetComponent<GameBehavior>();
     }
 
     void OnCollisionEnter(Collision collision)
     {
         if (collision.gameObject.name == "Player")
         {
             Destroy(this.transform.parent.gameObject);
             Debug.Log("Item collected!");
         }
             gameManager.Items += 1;
             gameManager.PrintLootReport();
         
     }
 } 