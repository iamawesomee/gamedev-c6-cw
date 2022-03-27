using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class load : MonoBehaviour
{
  void OnEnable(){
      SceneManager.LoadScene("lvl1",LoadSceneMode.Single); 
  }
}
