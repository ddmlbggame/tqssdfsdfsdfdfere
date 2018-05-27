using System;

namespace AppAdvisory.BallX
{
	public interface IHitableByBall
	{
		event OnDestroyedEventHandler OnDestroyedByBall;

		void BallHit(Ball ball);

		void BombHit(missile missile);

		void RedHit(MissileRed missilered);

		void BombaHit(BombScriptExplosion bombe);

		void BombaAtomicaHit(RaycastCircle bombaAtomica);

		void RedContinueHit(RedCol continua);
	}
}
