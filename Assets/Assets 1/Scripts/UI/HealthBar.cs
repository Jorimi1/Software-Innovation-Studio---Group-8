using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
	public BossHealth bossHealth;
	public Slider slider;
	public int maxValue;
	void Start()
	{
		//slider.maxValue = bossHealth.health;
		slider.maxValue = maxValue;
	}

	// Update is called once per frame
	void Update()
    {
		slider.value = bossHealth.health;
    }
}
