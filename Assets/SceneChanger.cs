using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    void OnTriggerEnter(Collider ChangeScene) // can be Collider HardDick if you want.. I'm not judging you
    {
        if (ChangeScene.gameObject.CompareTag("Player"))
        {
            Application.LoadLevelAdditive(1); //1 is the build order it could be 1065 for you if you have that many scenes
        }
    }

}
