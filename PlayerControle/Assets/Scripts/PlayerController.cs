using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public AudioSource cubeAudio;
    public AudioSource cylinderAudio;
    public AudioSource capsuleAudio;
    public AudioSource sphereAudio;


    public Text score;
    int tmp = 0;
    int counter = 0;

    public GameObject restartPanel;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0, 45f, 0);
        }if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(0, -45f, 0);
        }

        if(counter == 8)
        {
            restartPanel.SetActive(true);
            gameObject.GetComponent<Animator>().enabled = false;
        }

    }

  

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "red")
        {
            Destroy(collision.gameObject);
            tmp -= 1;
            counter++;
            score.text = tmp.ToString();
        }
        if (collision.gameObject.tag == "green")
        {
            Destroy(collision.gameObject);
            tmp += 1;
            counter++;
            score.text = tmp.ToString();
        }

        if(collision.gameObject.name == "Cube"||collision.gameObject.name == "Cube1")
        {
            cubeAudio.Play();
        }

        if (collision.gameObject.name == "Sphere" || collision.gameObject.name == "Sphere1")
        {
            sphereAudio.Play();
        }
        if (collision.gameObject.name == "Capsule" || collision.gameObject.name == "Capsule1")
        {
            capsuleAudio.Play();
        }
        if (collision.gameObject.name == "Cylinder" || collision.gameObject.name == "Cylinder1")
        {
            cylinderAudio.Play();
        }
    }


    public void restart()
    {
        SceneManager.LoadScene(0);
    }

    public void exit()
    {
        Application.Quit(); 
    }

}
