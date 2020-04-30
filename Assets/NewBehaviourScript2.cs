using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowMessage("go to the box to win", 10));
    }

    // Update is called once per frame
    void Update()
    {
         if (GameObject.FindGameObjectWithTag("Player").transform.position.x == 124) {
     		StartCoroutine(ShowMessage("You win", 40));
 	 }
    }

         IEnumerator ShowMessage (string message, float delay) {
         GetComponent<GUIText>().text = message;
         GetComponent<GUIText>().enabled = true;
         yield return new WaitForSeconds(delay);
         GetComponent<GUIText>().enabled = false;
     }
}
