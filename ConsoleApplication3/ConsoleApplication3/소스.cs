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

//혹은 타임매니저
/*fixed Timestep	물리 계산과 FixedUpdate() 이벤트가 수행되었을때를 나타내는 프레임률에 의존하지 않는 간격.
Maximum Allowed Timestep	프레임 속도가 낮은 경우에, 최악의 시나리오를 제한하는 프레임률에 의존하지 않는 간격. 물리 특성 계산 및 FixedUpdate() 이벤트는 지정된 시간을 초과하여 실행되지 않습니다.
Time Scale	시간이 진행되는 속도. 불릿 타임 효과(Bullet-time effect)를 시뮬레이션하려면 이 값을 변경합니다. 1은 실시간을 의미합니다. 0.5면 그 절반의 속도이고, 2면 속도가 2배가 됩니다.
*/

