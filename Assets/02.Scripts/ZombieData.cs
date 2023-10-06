using UnityEngine;

// ���� ������ ����� �¾� ������(�����̳�)
[CreateAssetMenu(menuName = "Scriptable/ZombieData",
    fileName = "Zombie Data")]
public class ZombieData : ScriptableObject
{
    public float health = 100f; // ü��
    public float damage = 20f; // ���ݷ�
    public float speed = 1f; // �̵� �ӵ�
    public Color skinColor = Color.white; // �Ǻλ�
}
