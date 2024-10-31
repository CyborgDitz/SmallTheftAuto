using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
   void OnCollisionEnter(Collision collision)
   {
      Debug.Log("The tower collapsed. You lose.");
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
}
