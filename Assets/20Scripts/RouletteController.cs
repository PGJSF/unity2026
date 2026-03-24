using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float startSpeed = 10f;
    public float decreaseRatio = 0.97f;
    float rotSpeed = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = startSpeed;
        }

        transform.Rotate(0, 0, rotSpeed);

        this.rotSpeed *= decreaseRatio;
        decreaseRatio -= 0.01f * Time.deltaTime;
    }
}
