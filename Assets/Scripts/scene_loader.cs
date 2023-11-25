using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene_loader : MonoBehaviour
   {
       [SerializeField] private string scene;

       public void Change()
       {
           SceneManager.LoadScene(scene);
       }
   }