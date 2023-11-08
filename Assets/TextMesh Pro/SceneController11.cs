using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;　　　//ボタンを使用するのでUI
using UnityEngine.SceneManagement;//SceneManagerを使用ためSceneManagementを追加

public class SceneController11 : MonoBehaviour
{

    // ボタンをクリックするとScene『B』に移動
    public void ButtonClick()
    {
        SceneManager.LoadScene("Quiz5");
    }
}