using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public static GameController ins;

    public Text score;
    public Text txtscore;
    public Text best;
    int point = 0;
    public const string High_score = "High_score";
    [SerializeField]
    private GameObject panelgameover, panelpause;
    void MakeIns()
    {
        if (ins == null)
        {
            ins = this;
        }
       
    }
    void IsGameStartedForTheFirstTime()
    {
        if (!PlayerPrefs.HasKey("IsGameStartedForTheFirstTime"))
        {
            PlayerPrefs.SetInt(High_score, 0);
            PlayerPrefs.SetInt("IsGameStartedForTheFirstTime", 0);
        }
    }
    private void Awake()
    {
        MakeIns();
        IsGameStartedForTheFirstTime();
    }

    public void setBestCore(int score)
    {
       
    }
    public int getBestCore()
    {
       
        return PlayerPrefs.GetInt(High_score);
    }

    void BestScore()
    {
        if(point > PlayerPrefs.GetInt(High_score))
        {
            PlayerPrefs.SetInt(High_score, point);
        }
        best.text = PlayerPrefs.GetInt(High_score).ToString();
    }
    public  void CountScore(int n)
    {
      
        point += n;
       
        score.text = point.ToString();
    }

    public void ClickPause()
    {
        panelpause.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ClickHome()
    {
       
        Application.LoadLevel("GameMenu");
       
    }
    public void ClickQuit()
    {
        Application.Quit();
    }
    public void ClickReplaypPause()
    {
        panelpause.SetActive(false);
        Time.timeScale = 1;
    }
   public void ClickReplay()
    {
      //  panelgameover.SetActive(true);
        Application.LoadLevel("GamePlay");
        ItemSquareController.kiemtravacham = 0;
    }


    public void LoadPanelGameover()
    {
       
        panelgameover.SetActive(true);
        BestScore();
        txtscore.text = score.text;
    }
}
