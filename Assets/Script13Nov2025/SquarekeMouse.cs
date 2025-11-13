using UnityEngine;

public class SquarekeMouse : MonoBehaviour
{
    public Transform CubeTransform; //mengikuti Mouse
    public Vector2 PosisiKlik;

    // Update is called once per frame
    void Update()
    {
        //Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); //untuk melihat posisi pada area scene/game
        //Debug.Log(Input.mousePosition); untuk melihat posisi dari kursor/posisi mouse di layar laptop/komputer bukan di scene
       // CubeTransform.position=worldMousePosition; //posisi cube akan mengikuti mouse tanpa delay (jika Cursor/mouse tidak terlalu cepat)
        //CubeTransform.position=Vector2.MoveTowards(CubeTransform.position, worldMousePosition, 0.1f); //untuk cube mengikuti cursor/mouse secara delay

        //Geser objek ke terakhir Klik mouse
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            PosisiKlik=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        CubeTransform.position =Vector2.MoveTowards(CubeTransform.position, PosisiKlik, 0.1f); //PosisiKlik, 0.1f untuk kecepatan saat Cube berpindah, semakin cepat maka di besarkan angka yang ada


    }
}
