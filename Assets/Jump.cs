using UnityEngine;

public class Jump : MonoBehaviour { // MonoBehaviour 상속
    Rigidbody2D rb;
    public float jumpForce; // 점프 힘 변수 (public이면 외부에서 설정 가능)

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // 프레임이 업데이트 될 때마다 호출되는 메서드
    void Update() {
        if (Input.GetMouseButtonDown(0)) { // 마우스 왼쪽 버튼 클릭 감지
            rb.linearVelocity = Vector2.up * jumpForce;
        }
    }
}
