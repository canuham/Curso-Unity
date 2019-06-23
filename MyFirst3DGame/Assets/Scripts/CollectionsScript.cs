using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionsScript : MonoBehaviour {

  public string student1 = "Christian";
  public string student2 = "Kate";
  public string student3 = "Mia";
  public string student4 = "Anastasia";

  /*
   ARRAY
   - Es homogeneo (solo un tipo de dat)
   - Es de tamaño fijo (una vez creado, no puede contener mas elementos)
   - Tiene un orden (Se accede por posicion)
     
   */

  public string[] students = new string[]{"Christian", "Kate", "Mia", "Anastasia"}; // El array es de tamaño fijo

  public string[] familiNames = new string[4]; //{,,,}

  public int[] numberOfDoorsInMyStreet = new int[] { 2, 3, 4, 5, 6 };

  /*
   LISTA
   - Es homogeneo (Solo un tipo de dato)
   - Es de tamaño ajustable (Podemos añadir mas elementos en tiempo real y eliminarlos)
   - Tiene un orden (Se accede por posicion)
   */

  public List<string> studentsNames = new List<string>();

  /*
   ARRAYLIST
   - Es heterogeneo (Puede guardar diferentes tipos de datos en la misma estructura)
   - Es de tamaño ajustable (Podemos añadir mas elementos en tiempo real y eliminarlos)
   - Tiene un orden (Se accede por posicion)
  */

  public ArrayList inventory = new ArrayList();

  /*
   DICCIONARIO <--> HASHTABLE
   - Se puede redimensionar dinamicamente
   - Puede contrener informacion heterogenea
   - Se accede por clave, no por posicion
  */

  public Hashtable personalDetails = new Hashtable();

  // Start is called before the first frame update
  void Start() {
    studentsNames.Add("Christian");
    studentsNames.Add("Camilo");
    studentsNames.Add("Fulano"); //Se añaden en la ultima posicion
    studentsNames.Add("Anastasia");
    studentsNames.Add("Jack");

    if (studentsNames.Contains("Jack")) { // Ver si el array contiene el elemento "Jack"
      studentsNames.Remove("Jack");
    }

    studentsNames.Insert(2, "Melissa");

    string[] studentsNamesToArray = studentsNames.ToArray(); // Convierte la lista en un array

    Debug.Log(students.Length); // Saber tamaño de un Array
    Debug.Log(studentsNames.Count); // Saber tamaño de una Lista

    Debug.Log("El primer estudiante del Array: " + students[0]);

    Debug.Log("El tercer estudiante de la Lista: " + studentsNames[2]);

    //Clear -> eliminar todos los elementos de la lista
    studentsNames.Clear();
    

    inventory.Add(30);
    inventory.Add(3.14159265);
    inventory.Add("Camilo Vargas");
    inventory.Add(false);
    inventory.Add(GameObject.FindGameObjectsWithTag("Fireworks"));

    //Pedimos el tipo de dato que va a salir del ArrayList
    Debug.Log(inventory[2].GetType());
    Debug.Log(inventory[4].GetType());

    personalDetails.Add("firstName", "Juan Camilo");
    personalDetails.Add("lastName", "Vargas");
    personalDetails.Add("age", 30);
    personalDetails.Add("gender", "Male");
    personalDetails.Add("isMarried", false);
    personalDetails.Add("hasChildren", false);

    Debug.Log(personalDetails["firstName"]);

    if (personalDetails.Contains("firstName") && personalDetails.Contains("age")) {
      string name = (string)personalDetails["firstName"];
      int age = (int)personalDetails["age"];
    } else {
      Debug.Log("El diccionario no contiene las claves que se han pedido");
    }


    Debug.Log(name);

  }



  // Update is called once per frame
  void Update() {

  }
}
