using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void BigMapRegistered(){
        SceneManager.LoadScene(sceneName:"BigMapRegistered");
    }
    public void BigMapFollow(){
        SceneManager.LoadScene(sceneName:"BigMapFollow");
    }
    public void PortraitMapRegistered(){
        SceneManager.LoadScene(sceneName:"PortraitMapRegistered");
    }
    public void PortraitMapFollow(){
        SceneManager.LoadScene(sceneName:"PortraitMapFollow");
    }
    public void CubeNav(){
        SceneManager.LoadScene(sceneName:"CubeNav");
    }
    public void Minimized(){
        SceneManager.LoadScene(sceneName:"Minimized");
    }
}
