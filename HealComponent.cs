using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrew.Components
{
	public class HealComponent : MonoBehaviour
	{
		[SerializeField] private int _heal;

		public void Heal(GameObject target)
		{
			var health = target.GetComponent<HealthComponent>();
			if (health != null)
			{
				health.ApplyHeal(_heal);
			}
		}
	}
}
