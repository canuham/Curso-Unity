using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableScript : MonoBehaviour {

  int superSecret; //Esto es PRIVADO! NO PUBLICO !; private int superSecret === int superSecret

  public int number1 = 5;
  public int number2 = 8;

  // Start is called before the first frame update
  void Start() {
    AddTwoNumbers(5, 8);
    SayHello("Camilo");
    string myMessage = createWelcome("Camilo");
  }

  // Update is called once per frame
  void Update() {
    if (Input.GetKeyDown(KeyCode.Return)) {
      int result = AddTwoNumbers(5, 8);

      Debug.Log(result);
    }
  }

  void AddTwoNumbers() {
    Debug.Log(number1 + number2);
  }

  void AddTwoNumbersAndShowResultInConsole(int firstNumber, int secondNumber) {
    Debug.Log(firstNumber + secondNumber);
  }

  int AddTwoNumbers( int firstNumber, int secondNumber) {
    int result = firstNumber + secondNumber;
    return result;
  }

  void SayHello(string username) {
    Debug.Log("Hola " + username);
  }

  string createWelcome(string username) {
    string message = "Bienvenido al Curso " + username;
    return message;
  }

  void DoubleNumber (float number) {
    Debug.Log(2.0f * number);
  }


}
