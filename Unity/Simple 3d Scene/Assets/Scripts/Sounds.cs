/* Designing Musical Games 2021
 * 
 * Central Audio class
 * 
 * One-stop shopping for our audio needs
 * 
 * - Footsteps
 * 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{

    AudioSource audioData;
    bool zPressed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkKeys();
    }

    public void PlayFootstep()
    {
        Debug.Log("Thump");

    }

    private void checkKeys()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            zPressed = !zPressed;
            Debug.Log("Pressing Z: " + zPressed);
            PlaySound(zPressed);
        }
    }

    public void PlaySound(bool pressed)
    {
        if (pressed == true)
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
        } else
        {
            audioData.Stop();
        }
    }
}
