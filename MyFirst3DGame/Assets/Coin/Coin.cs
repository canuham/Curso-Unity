/*
  NAMESPACE
*/

using System.Collections;
using UnityEngine;

/*
  Start of Class 
*/

public class Coin : MonoBehaviour {

  // Variables y Metodos

  public static int coinsCount = 0; // Static por que solo necesito un contador entonces esta variable se compartira entre todos los que tengan este script (Una variable para todas las monedas)

  // Start is called before the first frame update
  void Start() {
    Coin.coinsCount++;
    Debug.Log("Hay: " + Coin.coinsCount);
  }

  // Update is called once per frame
  void Update() {

  }

  // Metodo que se llama automaticamente cuando otro collider entra en contacto con el que tiene este script (La moneda)
  private void OnTriggerEnter(Collider otherCollider)
  {
    if (otherCollider.CompareTag("Player") == true) {
      Debug.Log("Algo ha colisionado con la moneda");
      Coin.coinsCount--;
      if (Coin.coinsCount == 0) {
        GameObject gameManager = GameObject.Find("GameManager"); //Encuentra el GameManager
        GameObject[] fireworksSystem = GameObject.FindGameObjectsWithTag("Fireworks"); //Encuentra los fireworks
        foreach(GameObject fireworks in fireworksSystem) {
          fireworks.GetComponent<ParticleSystem>().Play();
        }
        Destroy(gameManager);

        }
      Destroy(gameObject);
    }   
  }
}
