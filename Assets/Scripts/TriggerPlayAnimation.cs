using UnityEngine;
using UnityEngine.Playables;

public class TriggerPlayTimeline : MonoBehaviour
{
    public PlayableDirector director;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            director.Play();
            gameObject.SetActive(false); // disable this trigger
        }
    }
}
