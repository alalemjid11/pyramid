using UnityEngine;

public class Beep : MonoBehaviour
{
   // public AudioSource audioSource;
   // public AudioClip beepSound;
    public float minDistance = 1.0f;
    public float maxDistance = 5.0f;
    public float minPitch = 1.0f;
    public float maxPitch = 2.0f;

    private void Update()
    {
        GameObject[] artifactObjects = GameObject.FindGameObjectsWithTag("Artifact");

        float closestDistance = float.MaxValue;
        foreach (GameObject artifactObject in artifactObjects)
        {
            float distance = Vector3.Distance(transform.position, artifactObject.transform.position);
            closestDistance = Mathf.Min(closestDistance, distance);
        }

        float normalizedDistance = Mathf.InverseLerp(minDistance, maxDistance, closestDistance);
        float targetPitch = Mathf.Lerp(minPitch, maxPitch, normalizedDistance);

      //  audioSource.pitch = targetPitch;

       // if (!audioSource.isPlaying)
        //{
        //    audioSource.clip = beepSound;
        //    audioSource.loop = true;
        //    audioSource.Play();
        //}
    }
}