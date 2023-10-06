using UnityEngine;

//[CreateAssetMenu(menuName = "메뉴 경로",
// fileName = "기본 파일명", order = 메뉴 상에서 순서)]
[CreateAssetMenu(menuName = "Scriptable/GunData", 
    fileName = "Gun Data")]
public class GunData : ScriptableObject
{
    public AudioClip shotClip; // 발사 소리
    public AudioClip reloadClip; // 재장전 소리

    public float damage = 25; // 공격력

    // 처음에 주어질 전체 탄알
    public int startAmmoRemain = 100;
    // 탄창 용량
    public int magCapacity = 25;

    // 탄알 발사 간격
    public float timeBetFire = 0.12f;
    // 재장전 소료 시간
    public float reloadTime = 1.8f;
}
