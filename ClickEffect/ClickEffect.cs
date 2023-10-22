using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEffect : MonoBehaviour
{
    [SerializeField] ParticleSystem particle;

    ParticleSystem.EmitParams emitSettings;

    private void Start()
    {
        emitSettings = new ParticleSystem.EmitParams();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0f;
            emitSettings.position = pos;
            particle.Emit(emitSettings, 1);
        }
    }
}
