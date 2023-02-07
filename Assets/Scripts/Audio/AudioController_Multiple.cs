using UnityEngine;

public class AudioController_Multiple : AudioController_Base
{
    [SerializeField] private AudioElement_Multiple m_audioMuliple;

    public AudioElement_Multiple AudioMuliple { get => m_audioMuliple; }

    override public void PlayOneShot()
    {
        m_audioSource.PlayOneShot(m_audioMuliple.GetClip());
    }
}
