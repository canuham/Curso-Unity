using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopsCript : MonoBehaviour {
  // Start is called before the first frame update
  void Start() {
    /* foreach(Type elementName in collection) { } */

    List<string> studentsNames = new List<string>();
    studentsNames.Add("Christian");
    studentsNames.Add("Camilo");
    studentsNames.Add("Fulano"); 
    studentsNames.Add("Anastasia");
    studentsNames.Add("Jack");

    foreach (string person in studentsNames) {
      Debug.Log(person);
    }
  }

// Update is called once per frame
void Update() {
  
  }
}
