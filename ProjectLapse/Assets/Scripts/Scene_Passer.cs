using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Passer : MonoBehaviour
{
    public float video_length=5f;
    void Start()
    {
        StartCoroutine(SceneEndCountdown());
    }
    IEnumerator SceneEndCountdown(){
        yield return new WaitForSeconds(video_length);
        SceneManager.LoadScene (sceneName:"Main_Menu");
    }
}
