using UnityEngine;

public class KMG_CekInput : MonoBehaviour
{
    public GameObject _targethancur;
    public GameObject _blip;

    public GameObject _untukSpawn;

    public GameObject _kotakBerwarna;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Tekan Tombol Spasi");
        }

        //untuk memunculkan Objek
        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Tekan Tombol O, Objek Tampil");
            _blip.SetActive(true);
        }

        //untuk menghilangkan Objek
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Tekan Tombol P, Objek Hilang");
            _blip.SetActive(false);
        }

        //untuk memunculkan Spawn Objek
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Tekan Tombol Enter");
            //Instantiate(_untukSpawn); untuk spawn di posisi dan rotasi dari titik nol

            Instantiate(_untukSpawn, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.Euler(0, 0, 0));
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            GameObject hancurkan = GameObject.FindGameObjectWithTag("sasaran"); //atau bisa menggunakan GameObject hancurkan = GameObject.Find("sasaran");
            Debug.Log("Tekan Tombol M, untuk Hilangkan/Hancurkan");
            Destroy(_targethancur);
            Destroy(hancurkan);
        }
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            //untuk warna berubah sekali sesuai dengan tombol dan permintaan di _localSpriteRenderer.color
            //SpriteRenderer _localSpriteRenderer = _kotakBerwarna.GetComponent<SpriteRenderer>();
            //_localSpriteRenderer.color = Color.black;

            //untuk membuat warna acak/memberikan warna secara acak(random)
            SpriteRenderer _localSpriteRenderer = _kotakBerwarna.GetComponent<SpriteRenderer>();
            Color warnaAcak = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            _localSpriteRenderer.color = warnaAcak;
        }

    }
}
