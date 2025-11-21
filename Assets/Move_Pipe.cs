using UnityEngine;

public class Move_Pipe : MonoBehaviour {
    public float speed;

    void Start() {

    }

    // Update is called once per frame
    void Update() {
        transform.position += Vector3.left * speed * Time.deltaTime; // 파이프를 왼쪽으로 이동 (deltaTime으로 프레임 독립적 속도 구현)

        if (transform.position.x < -10) { // 파이프가 화면 밖으로 나가면 삭제
            Destroy(gameObject);
        }
    }
}
