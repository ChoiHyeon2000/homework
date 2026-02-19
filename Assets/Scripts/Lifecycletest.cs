using UnityEngine;

public class life : MonoBehaviour
{
    int framecount = 0;

    private void Awake()
    {
        Debug.Log("1. Awake 기상! 데이터 준비중");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("2. Start 준비완료");
    }

    // Update is called once per frame
    void Update()
    {
        framecount++;

        if(framecount % 60  == 0)
        {
            Debug.Log("게임 돌아가는 중");
        }
    }
}
