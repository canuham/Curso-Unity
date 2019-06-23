using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionScript : MonoBehaviour {
  public bool willItRainToday = false;

    // Start is called before the first frame update
  void Start() {
    if (willItRainToday) {
      Debug.Log("No te olvides de coger el paraguas");
    } else {
      Debug.Log("No lo cojas, que hace mucho sol!!");
    }

    if(!willItRainToday) {
      Debug.Log("Vamos al cine!");
    }

    bool iAmLate = true;
    bool isThereSomeTraffic = false;

    if (iAmLate && !isThereSomeTraffic) {
      Debug.Log("Dale al gas que llego tarde!!");
    } else {
      Debug.Log("O bien hay trafico, o no llego tarde");
    }

    bool iAmHungry = true;
    bool kidsAreHungry = false;

    if (iAmHungry || kidsAreHungry) {
      Debug.Log("Vamos a hacer la comida");
    } else {
      Debug.Log("Nadie tiene hambre");
    }

    int maxSpeed = 120;

    if (maxSpeed == 120) {
      Debug.Log("Podemos ir a fondo");
    } else if (maxSpeed < 120 && maxSpeed >= 60) {
      Debug.Log("Podemos ir a velocidad de cruce!");
    } else if (maxSpeed < 60 && maxSpeed >= 40) {
      Debug.Log("Debemor ir a velocidad de ciudad");
    } else if (maxSpeed < 40 && maxSpeed >= 0) {
      Debug.Log("Mejor vamos dando un paseo...");
    } else {
      Debug.LogError("Velocidad no valida...");
    }

    if(EnterTheParty(30, 25)) {
      Debug.Log("Bienvenido a la fiesta!");
    } else {
      Debug.Log("No tienes permisos para entrar");
    }

  }

  

  // Update is called once per frame
  void Update() {
        
  }

  bool EnterTheParty(int age, int money) {
    if (age >= 18 && money >= 10) {
      return true;
    } else {
      return false;
    }
  }
}
