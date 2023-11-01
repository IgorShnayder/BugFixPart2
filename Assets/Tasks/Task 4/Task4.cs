using UnityEngine;

public class Task4 : MonoBehaviour
{
    [SerializeField] 
    private Transform _shelfPrefab;
    
    private void Start()
    {
        Destroy(_shelfPrefab);
        Instantiate(_shelfPrefab); // Эту строку кода удалять нельзя
    }
}
