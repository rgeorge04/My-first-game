using UnityEngine;
using UnityEngine.UI;
public class PlayerScore : MonoBehaviour
{
    public Text score;
    public Text highscore;
    public Transform player;


    void Start()
    {
        highscore.text = PlayerPrefs.GetFloat("HighScore", 0).ToString("0");
    }


    void Update()
    {
        float number = player.position.y * 15;
        Debug.Log(number);
        score.text = "Score: " + number.ToString("0");
        if (number > PlayerPrefs.GetFloat("HighScore", 0))
        {
            PlayerPrefs.SetFloat("HighScore", number);
        }
    }


    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highscore.text = "0";
    }

}






    
