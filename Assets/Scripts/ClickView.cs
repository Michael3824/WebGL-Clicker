using UnityEngine;
using TMPro;
public class ClickView : MonoBehaviour
{
    // View Œ©‚½–Ú‚Ì•Ï‰»
    // private TextMeshProUGUI‚ªg‚¦‚éŒ^ ScoreText ‚Ì•Ï”‚ğéŒ¾
    [SerializeField]
    private TextMeshProUGUI ScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScoreText.text = ClickData.instance.Score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = ClickData.instance.Score.ToString();
    }
}
