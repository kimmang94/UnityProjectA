using UnityEngine;

//[CreateAssetMenu(menuName = "�޴� ���",
// fileName = "�⺻ ���ϸ�", order = �޴� �󿡼� ����)]
[CreateAssetMenu(menuName = "Scriptable/GunData", 
    fileName = "Gun Data")]
public class GunData : ScriptableObject
{
    public AudioClip shotClip; // �߻� �Ҹ�
    public AudioClip reloadClip; // ������ �Ҹ�

    public float damage = 25; // ���ݷ�

    // ó���� �־��� ��ü ź��
    public int startAmmoRemain = 100;
    // źâ �뷮
    public int magCapacity = 25;

    // ź�� �߻� ����
    public float timeBetFire = 0.12f;
    // ������ �ҷ� �ð�
    public float reloadTime = 1.8f;
}
