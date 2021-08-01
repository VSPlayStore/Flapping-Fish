using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdMovement : MonoBehaviour
{
    public Button restart;
    private Rigidbody2D rb;
    private Animator animator;
    public AudioSource fly, death;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        restart.gameObject.SetActive(false);
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            fly.Play();
            animator.SetBool("fly", true);
            animator.SetBool("glide", false);
            rb.velocity = new Vector3(0, 50, 0);
        } else
        {
            animator.SetBool("fly", false);
            animator.SetBool("glide", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground") || collision.gameObject.CompareTag("Pipe"))
        {
            death.Play();
            rb.bodyType = RigidbodyType2D.Static;
            Time.timeScale = 0;
            restart.gameObject.SetActive(true);
            restart.onClick.AddListener(() => ResetGame());
        }
    }

    private void ResetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Score.score = 0;
        rb.bodyType = RigidbodyType2D.Dynamic;
        Time.timeScale = 1;
    }
}
