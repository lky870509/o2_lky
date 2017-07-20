using UnityEngine;
using System.Collections;

public class example: MonoBehaviour
{
	float timeSpan;  //경과 시간을 갖는 변수
	float checkTime;  // 특정 시간을 갖는 변수

	void Start()
	{
		timeSpan = 0.0f;
		checkTime = 10800.0f;  // 특정시간을 5초로 지정
	}

	void Update()
	{
		timeSpan += Time.deltaTime;  // 경과 시간을 계속 등록
		if (timeSpan > checkTime)  // 경과 시간이 특정 시간이 보다 커졋을 경우
		{
			/*
              밤낮으로 변환 혹은 계절 변화등의 이벤트 발생
            */
			timeSpan = 0;
		}
	}

}//일정 시간 마다 특정 작업 반복 처리

/*(1)public Sprite CurrentSprite; 
    public Sprite NextSprite; 
    private SpriteRenderer spriteRenderer; 

    void Start() 
    { 
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>(); 
        spriteRenderer.sprite = CurrentSprite; 
    } 


    void Update() 
    { 
        if (Input.GetKeyDown(KeyCode.A)) 
        { 
            spriteRenderer.sprite = NextSprite; 
        } 
    } 

	(2)public class A : MonoBehaviour
{
    public GameObject imageObj;
    public Image myImage;
 
    Start()
    {
        imageObj = GameObject.FindGameObjectWithTag("userTag1");
        myImage = imageObj.GetComponent<Image>();
    }
 
 
 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Func();
        }
    }
 
 
    void Func()
    {
        mySkimyImage.sprite = 
                        Resources.Load<Sprite>("SkillIcons/Sword_Skill") 
                        as Sprite;
    }
}


출처: http://is03.tistory.com/52 [Programming]

	(3)https://www.youtube.com/watch?v=40ktY3S5sQQ

	스프라이트 변경 스크립트*/
