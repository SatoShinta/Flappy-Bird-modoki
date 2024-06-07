using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;

    public void Update()
    {
    //もしもESCキーを押した場合
        if ( Input.GetKeyUp(KeyCode.Escape))
        {
        //ゲームを落とす
            Application.Quit();
            Debug.Log("ゲームを終了しました");
        }
    }


    //メニューに項目を追加する(下記のスクリプトが実行されるのでテストに最適）
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
    //プレイヤースコアはscoreToAddで追加される
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
    //この関数が呼び出されたらアクティブなシーンを読み込む
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
    //ゲームオーバーのフラグをtureにする
        gameOverScreen.SetActive(true);
        //playerに"Player"タグを持っているオブジェクトを取得する
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        //先ほど取得したオブジェクトを破壊する
        Destroy(player);
        
    }
}
