using UnityEngine;
using System.Collections;

public class example: MonoBehaviour
{
	float timeSpan;  //��� �ð��� ���� ����
	float checkTime;  // Ư�� �ð��� ���� ����

	void Start()
	{
		timeSpan = 0.0f;
		checkTime = 10800.0f;  // Ư���ð��� 5�ʷ� ����
	}

	void Update()
	{
		timeSpan += Time.deltaTime;  // ��� �ð��� ��� ���
		if (timeSpan > checkTime)  // ��� �ð��� Ư�� �ð��� ���� Ŀ���� ���
		{
			/*
              �㳷���� ��ȯ Ȥ�� ���� ��ȭ���� �̺�Ʈ �߻�
            */
			timeSpan = 0;
		}
	}

}//���� �ð� ���� Ư�� �۾� �ݺ� ó��

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


��ó: http://is03.tistory.com/52 [Programming]

	(3)https://www.youtube.com/watch?v=40ktY3S5sQQ

	��������Ʈ ���� ��ũ��Ʈ*/
