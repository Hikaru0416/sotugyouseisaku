using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ボタンを使用するためUIとSceneManagerを使用ためSceneManagementを追加
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScene : MonoBehaviour
{
   
    //Button button;

    public AudioClip impact;
    AudioSource audio;

    //public void StringArgFunction(string s)
    //{
    //    SceneManager.LoadScene("stage1");
    //}
    void Start()
    {
        //button = GameObject.Find("/Canvas/Button1").GetComponent<Button>();

        audio = GetComponent<AudioSource>();
    }

    //void OnCollisionEnter()
    //{
    //    audio.PlayOneShot(impact, 10.0F);
    //}
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audio.PlayOneShot(impact);
            DontDestroyOnLoad(this.gameObject);

            SceneManager.LoadScene("stage1");
        }
    }


    // ボタンをクリックするとBattleSceneに移動します
    //public void ButtonClicked()
    //{
    //    audio.PlayOneShot(impact, 10.0F);

    //    SceneManager.LoadScene("stage1");
    //}
}