using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

  public float maxTime = 30f;

  private float countdown = 0f;

  // Start is called before the first frame update
  void Start() {
    countdown = maxTime;
  }

  // Update is called once per frame
  void Update() {
    countdown -= Time.deltaTime; // deltaTime = Tiempo que hay entre frames
    if (countdown <= 0) {
      Debug.Log("Te has quedado sin tiempo... Has PERDIDO!!!!");
      Coin.coinsCount = 0;
      SceneManager.LoadScene("MainScene");
    }
  }
}
