using UnityEngine;
using Unity.Services.Leaderboards.Models;
using TMPro;

public class LeaderboardPlayerinfo : MonoBehaviour
{
    public TextMeshProUGUI RankText;
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI PlayerNameText;

    private LeaderboardEntry player;

    public void Initialisation(LeaderboardEntry player)
    {
        this.player = player;
        RankText.text = player.Rank.ToString();
        ScoreText.text = player.Score.ToString();
        PlayerNameText.text = player.PlayerName.ToString();
    }
}
