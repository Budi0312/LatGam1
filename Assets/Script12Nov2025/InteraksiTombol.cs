using TMPro;
using UnityEngine;

public class InteraksiTombol : MonoBehaviour
{
    public SquareMove12B squareMove12B;
    public TMP_Text TeksSkor;
    public TMP_Text KurangNyawa;
    public int skor;
    public int nyawa;

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GerakAtas()
    {
        squareMove12B.arahGerak = ArahGerak.atas;
    }
    public void GerakBawah ()
    {
        squareMove12B.arahGerak = ArahGerak.bawah;
    }
    public void GerakKanan ()
    {
        squareMove12B.arahGerak = ArahGerak.kanan;
    }
    public void GerakKiri()
    {
        squareMove12B.arahGerak = ArahGerak.kiri;
    }
    
}
