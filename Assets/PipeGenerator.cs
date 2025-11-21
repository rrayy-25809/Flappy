using UnityEngine;

public class PipeGenerator : MonoBehaviour {
    public GameObject pipePrefab;
    float timer = 0;
    public float spawnRate; // 파이프 생성 주기

    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (timer < spawnRate) {
            timer += Time.deltaTime; // deltaTime: 이전 프레임이 끝나고 현재 프레임이 시작될 때까지의 시간 ex) 60FPS -> 1/60초
        } else {
            GameObject Pipe = Instantiate(pipePrefab); // GameObject를 생성하는 함수
            Pipe.transform.position = new Vector3(1, Random.Range(-3.0f, 1.0f), 0); // 파이프의 위치 설정
            timer = 0;
        }
    }
}
