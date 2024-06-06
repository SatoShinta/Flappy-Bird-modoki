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
        if ( Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("�Q�[�����I�����܂���");
        }
    }


    //���j���[�ɍ��ڂ�ǉ�����(���L�̃X�N���v�g�����s�����̂Ńe�X�g�ɍœK�j
    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Destroy(player);
        
    }
}
