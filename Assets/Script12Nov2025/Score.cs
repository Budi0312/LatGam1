using Unity.VisualScripting;
using UnityEngine;

public class Score : MonoBehaviour
{
    public DeteksiInput objectDeteksiInput;

    public int score;

    private void OnEnable()
    {
        //tanda += yang mau Listen
        //objectDeteksiInput.inputEvent += AddScore;
        //objectDeteksiInput.inputEvent.AddListener(AddScore); //jika menggunakan public UnityEvent
    }

    public void AddScore()
    {
        score = score + 1;
    }

    private void OnDisable()
    {
        /*tanda -= yang mau UnListen*/
        //objectDeteksiInput.inputEvent -= AddScore;
        //objectDeteksiInput.inputEvent.RemoveListener(AddScore); //jika menggunakan public UnityEvent
    }
}
