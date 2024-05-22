using UnityEngine;

public class Gun_2 : GunBase
{
    [SerializeField] private Transform[] bulletPoint;
    [SerializeField] private BulletBase bulletBasePrefab;
    public override void Shoot()
    {
        base.Shoot();
        for (int i = 0; i < bulletPoint.Length; i++)
        {

            //BulletBase b = Instantiate(bulletBasePrefab, bulletPoint[i].position, bulletPoint[i].rotation);
            BulletBase b = SimplePool.Spawn<BulletBase>(PoolType.Bullet_2, bulletPoint[i].position, bulletPoint[i].rotation);

            b.OnInit(10);
        }
    }
}
