using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Microsoft.Win32.SafeHandles;

public class Ball : MonoBehaviour
{
    public Rigidbody2D ball;
    [SerializeField] private float jumpPower;
    [SerializeField] private Color turquoiseColor, yellowColor, pinkColor, purpleColor;
    [SerializeField] private string currentColor;
    [SerializeField] private SpriteRenderer artist;
    [SerializeField] private Transform changer;
    [SerializeField] private TextMeshProUGUI EndText, scoreText,HighscoreText,coinText;
    [SerializeField] private GameObject endPanel;
    [SerializeField] private int score,highScore;
    [SerializeField] private Transform control1, control2, circle1, circle2;
    [SerializeField] private AudioSource jumpVoice;
    public UIManager uimanager;

    private void Start()
    {
        score = 0;
        Turning.turningSpeed = 1;
        RandomColor();
        if (PlayerPrefs.HasKey("Highscore"))
        {
            highScore = PlayerPrefs.GetInt("Highscore");
            HighscoreText.text = "HighScore :" + highScore.ToString();
        }
    }


    void Update()
    {
        Debug.Log(Turning.turningSpeed);
        scoreText.text = "Your Score:" + score.ToString();
        EndText.text = "Game Over!";
        if (Input.GetMouseButtonDown(0))
        {
            ball.velocity = Vector2.up * jumpPower;
            jumpVoice.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D contact)
    {
        if (contact.tag != currentColor && contact.tag != "Changer" && contact.tag != "C1" && !contact.CompareTag("C2"))
        {
            endPanel.SetActive(true);
            Time.timeScale = 0;
        }
        if (contact.CompareTag("Changer"))
        {
            score++;
            changer.position = new Vector3(changer.position.x, changer.position.y + 5f, changer.position.z);
            RandomColor();
            Turning.turningSpeed += 0.01f;

            if (score>highScore)
            {
                highScore = score;
                HighscoreText.text="Highscore:"+highScore.ToString();
                PlayerPrefs.SetInt("Highscore", highScore);
            }
            else
            {
                //highScore = 0;
            }
        }
        if (contact.CompareTag("C1"))
        {
            control1.position = new Vector3(control1.position.x, control1.position.y + 10f, control1.position.z);
            circle1.position = new Vector3(circle1.position.x, circle1.position.y + 10f, circle1.position.z);
        }

        if (contact.CompareTag("C2"))
        {
            control2.position = new Vector3(control2.position.x, control2.position.y + 10f, control2.position.z);
            circle2.position = new Vector3(circle2.position.x, circle2.position.y + 10f, circle2.position.z);
        }
    }

    void RandomColor()
    {
        int random = Random.Range(0, 4);
        switch (random)
        {
            case 0:
                currentColor = "Turquoise";
                artist.color = turquoiseColor;
                break;
            case 1:
                currentColor = "Yellow";
                artist.color = yellowColor;
                break;
            case 2:
                currentColor = "Pink";
                artist.color = pinkColor;
                break;
            case 3:
                currentColor = "Purple";
                artist.color = purpleColor;
                break;
        }
    }
}
