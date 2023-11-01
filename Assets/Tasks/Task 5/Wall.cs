using UnityEngine;
/// <summary>
/// Измените этот скрипт
/// </summary>
public class Wall : MonoBehaviour
{
    [SerializeField]
    private Detector _detector;
    [SerializeField] 
    private Vector3 _tagetPosition = new(0, 0, 0f);

    private void Awake()
    {
        _detector = FindAnyObjectByType<Detector>();

        if (_detector != null)
        {
            _detector.CoinDetected += ChangePosition;
        }
    }

    private void ChangePosition()
    {
        transform.position = _tagetPosition;
    }
}