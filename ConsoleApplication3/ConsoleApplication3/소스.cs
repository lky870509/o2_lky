using UnityEngine;
using System.Collections;

public class ExampleScript : MonoBehaviour
{
	void Pause()
	{
		Time.timeScale = 0;
	}

	void Resume()
	{
		Time.timeScale = 4;
	}
}

//Ȥ�� Ÿ�ӸŴ���
/*fixed Timestep	���� ���� FixedUpdate() �̺�Ʈ�� ����Ǿ������� ��Ÿ���� �����ӷ��� �������� �ʴ� ����.
Maximum Allowed Timestep	������ �ӵ��� ���� ��쿡, �־��� �ó������� �����ϴ� �����ӷ��� �������� �ʴ� ����. ���� Ư�� ��� �� FixedUpdate() �̺�Ʈ�� ������ �ð��� �ʰ��Ͽ� ������� �ʽ��ϴ�.
Time Scale	�ð��� ����Ǵ� �ӵ�. �Ҹ� Ÿ�� ȿ��(Bullet-time effect)�� �ùķ��̼��Ϸ��� �� ���� �����մϴ�. 1�� �ǽð��� �ǹ��մϴ�. 0.5�� �� ������ �ӵ��̰�, 2�� �ӵ��� 2�谡 �˴ϴ�.
*/

