using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    public Transform Player;
    public Text score;

    void Update()
    {
        Debug.Log(Player.position.z);
        score.text = Player.position.z.ToString("0.0");
    }
}
