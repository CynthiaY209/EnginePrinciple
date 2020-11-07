using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Manager : MonoBehaviour
{
    private string SceneName;

    void Start()
    {
        GetScene();
    }
    private void GetScene()//调用此函数获得场景信息
    {
        SceneName = SceneManager.GetActiveScene().name;//获取场景名称

    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneName); 
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.R))
            ReloadScene();
    }
}
