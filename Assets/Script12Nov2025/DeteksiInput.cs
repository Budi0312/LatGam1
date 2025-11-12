using UnityEngine;

public class DeteksiInputt : MonoBehaviour
{
    public Score objectScore;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            objectScore.AddScore();
        }
    }
}
