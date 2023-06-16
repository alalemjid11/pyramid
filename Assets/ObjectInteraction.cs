using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public int requiredArtifactCount = 3;

    private int currentArtifactCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Artifact"))
        {
            currentArtifactCount++;

            if (currentArtifactCount == requiredArtifactCount)
            {
                particleSystem.Play();
            }
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Artifact"))
        {
            currentArtifactCount--;

            if (currentArtifactCount < requiredArtifactCount)
            {
                particleSystem.Stop();
            }
        }
    }
}
