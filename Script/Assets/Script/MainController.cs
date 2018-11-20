using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//monoBehaviour: 사전에 구현이 된 것, 내부적인 처리와 연동을 해주는 클래스
public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //객체의 위치 설정하고 싶을 때 사용 (초기화 부분)
        Debug.Log("초기화가 이루어졌습니다.");
	}
	
	// Update is called once per frame
	void Update () {
		//매 프레임마다 실행되는 하나의 함수
        //논리적인 흐름 처리
	}
}
