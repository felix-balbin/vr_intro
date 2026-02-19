using UnityEngine;

public class ActivateExintor : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource source;
    public ParticleSystem particles;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        source = GetComponent<AudioSource>();
        particles = GetComponent<ParticleSystem>();

    }

    public void FireFoam()
    {
        // Sonido
        if (clip != null && source != null)
            source.PlayOneShot(clip);
            //source.Play(clip);

        // Partículas
        if (particles != null)
            particles.Play();

    }
}
