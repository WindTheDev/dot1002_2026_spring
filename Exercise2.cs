void PlaySound(AudioClip clip, float pitch = 1.0f) { 
    AudioSource audio = GetComponent<AudioSource>();
    audio.clip = clip;
    audio.pitch = pitch; 
    audio.Play();
}

void Jump() {
    PlaySound(jumpSound, 1.2f);
    rb.velocity = Vector2.up * jumpForce;
}

void Shoot() {
    PlaySound(shootSound, 0.8f);
    Instantiate(bullet);
}