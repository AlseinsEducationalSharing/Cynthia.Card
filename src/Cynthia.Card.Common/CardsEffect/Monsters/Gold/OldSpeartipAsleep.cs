using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("22001")]//老矛头：昏睡
	public class OldSpeartipAsleep : CardEffect
	{//使手牌、牌组和己方半场除自身外所有“食人魔”单位获得1点强化。
		public OldSpeartipAsleep(IGwentServerGame game, GameCard card) : base(game, card){}
		public override async Task<int> CardPlayEffect(bool isSpying)
		{
			return 0;
		}
	}
}