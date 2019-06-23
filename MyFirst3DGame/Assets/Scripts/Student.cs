using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : MonoBehaviour {

  public string firstName = "Luke";
  public string lastName = "Skywalker";
  public string email = "a@gmail.com";
  public int age = 32;
  public float height = 1.78f;
  public float weight = 82.5f;

  bool booleanVariable; // True o False
  int integerVariable; // -3, -2, -1, 0, 1, 2, 3,...
  float realVariable; // 3.14159265, 6.28, -4,23
  char characterVariable = 'a'; // 'a', 'b', '7', '@', '#'
  string stringVariable = "Hola, me llamo Camilo"; // 'Hola', 'Cadenas'

  // Start is called before the first frame update
  void Start() {
    float playerHeight = transform.position.x;
  }

  // Update is called once per frame
  void Update() {

  }
}
