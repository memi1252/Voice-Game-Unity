using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public static PlayerController Instance { get; private set; }
    
    
    [Tooltip("마이크 입력 오디오 클립")] public AudioClip audioClip;

    [Tooltip("오디오 분석을 위한 샘플 레이트")] private int sampleRate = 44100;

    [Tooltip("오디오 샘플 배열")] private float[] samples;

    [Tooltip("RMS (Root Mean Square) 값")] public float rmsValue;

    [Tooltip("RMS 값 조절을 위한 변조값")] public float modulate;

    public float resultValue;

    [Tooltip("최소 컷 값")] public int cutValue;

    public bool IsLive = true;
    
    /// <summary>
    /// GPT쓰지마
    /// </summary>
    private void Start()
    {
        Time.timeScale = 1;

        IsLive = true;

        Instance = this;
        
        samples = new float[sampleRate];
        
        if (Microphone.devices.Length > 0)
        {
            audioClip = Microphone.Start(Microphone.devices[0].ToString(), true, 1, sampleRate);
        }
        else
        {
            Debug.LogError("사용 가능한 마이크가 없습니다.");
        }
    }

    private void Update()
    {
        Move();
        // 점프 조절
        AdjustJump();
        AnalyzeAudio();
        Die();
    }

    private void AnalyzeAudio()
    {
        if (audioClip == null || !Microphone.IsRecording(null))
        {
            return;
        }

        audioClip.GetData(samples, 0);
        float sum = 0;

        for (int i = 0; i < samples.Length; i++)
        {
            sum += samples[i] * samples[i];
        }

        rmsValue = Mathf.Sqrt(sum / samples.Length);
        rmsValue *= modulate;
        rmsValue = Mathf.Clamp(rmsValue, 0, 100);
        resultValue = Mathf.RoundToInt(rmsValue);
        if (resultValue < cutValue)
        {
            resultValue = 0;
        }

    }

    private void AdjustJump()
    {
        if (IsLive)
        {
            if (rmsValue >= 3 && rmsValue < 10)
            {
                transform.position += new Vector3(0, 0.04f, 0);
            }
            else if (rmsValue >= 10 && rmsValue < 20)
            {
                transform.position += new Vector3(0, 0.06f, 0);
            }
            else if (rmsValue >= 20 && rmsValue < 30)
            {
                transform.position += new Vector3(0, 0.09f, 0);
            }
            else if (rmsValue >= 30)
            {
                transform.position += new Vector3(0, 0.12f, 0);
            }
        }
    }

    private void Move()
    {
        float movespeed = 3f;
        transform.Translate(Vector3.right * movespeed * Time.deltaTime);
    }

    private void Die()
    {
        if (transform.position.y < -7)
        {
            DieUI.Instance.Show();
            Time.timeScale = 0;
            IsLive = false;
        }
    }
}
