using UnityEngine;
using Unity.Services.Leaderboards;

public class LeaderboardMenu : MonoBehaviour
{
    public int maxPlayerInLeaderboards = 10;
    public LeaderboardPlayerinfo playerinfoPrefabs;
    public RectTransform playerList;

    public async void addScoreAsync(int score)
    {
        var playerEntry = await LeaderboardsService.Instance.AddPlayerScoreAsync(leaderboardId: "OnlineLeaderboard",score);
        LoadPlayer();
    }
    public async void LoadPlayer()
    {
        var scores = await LeaderboardsService.Instance.GetScoresAsync(leaderboardId: "OnlineLeaderboard");
        for (int i = 0; i < scores.Results.Count; i++) 
        {
            LeaderboardPlayerinfo playerinfo = Instantiate(playerinfoPrefabs, playerList);
            playerinfo.Initialisation(scores.Results[i]);
        }
    }
    
}
