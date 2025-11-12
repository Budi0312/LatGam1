using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    public DeteksiInput objectDeteksiInput;

    public int score;

    private void OnEnable()
    {
        //tanda += yang mau Listen
        objectDeteksiInput.inputEvent += AddScore;
    }

    public void AddScore()
    {
        score = score + 1;
    }

    private void OnDisable()
    {
        /*tanda -= yang mau UnListen*/
        objectDeteksiInput.inputEvent -= AddScore;
    }
}
