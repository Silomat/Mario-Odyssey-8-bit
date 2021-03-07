using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DeadZone"))
        {
            DyingSound();
        }
    }

  public  void DyingSound()
    {

        FMODUnity.RuntimeManager.PlayOneShot("event:/death");



        Time.timeScale = 0f;
        Restart();
    }
     public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
