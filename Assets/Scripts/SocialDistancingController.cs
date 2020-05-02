using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SocialDistancingController : MonoBehaviour
{
    public Material red;
    public Material green;

    public AudioClip Siren;
    public AudioClip Beep;

    public Text DistanceText;

    private AudioSource audioData;


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "collider")
        {
            Debug.Log("OnCollisionEnter");
            Debug.Log("Hit: " + collision.transform.name);
            gameObject.GetComponent<MeshRenderer>().material = red;

            audioData = GetComponent<AudioSource>();
            audioData.clip = Siren;
            audioData.Play();

            if (DistanceText != null)
            {
                DistanceText.text = "Distance: TOO CLOSE";
                DistanceText.gameObject.GetComponent<Text>().color = Color.red;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "collider")
        {
            Debug.Log("OnCollisionExit");
            Debug.Log("No longer in contact with: " + other.transform.name);
            gameObject.GetComponent<MeshRenderer>().material = green;

            audioData = GetComponent<AudioSource>();
            audioData.clip = Beep;
            audioData.Play();

            if (DistanceText != null)
            {
                DistanceText.text = "Distance: GOOD";
                DistanceText.gameObject.GetComponent<Text>().color = Color.green;
            }
        }
    }
}
