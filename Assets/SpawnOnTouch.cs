using UnityEngine;

public class SpawnOnTouch : MonoBehaviour
{
    public GameObject spawnedObject;
    public ParticleSystem particleSystem;

    private void Start()
    {
        particleSystem.Stop();
        spawnedObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnedObject.SetActive(true);
            particleSystem.Play();
        }
    }
}
