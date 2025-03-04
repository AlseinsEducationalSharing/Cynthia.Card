using System.Linq;
using System.Threading.Tasks;
using Alsein.Extensions;

namespace Cynthia.Card
{
	[CardEffectId("64019")]//迪门家族战船
	public class DimunWarship : CardEffect
	{//连续4次对同一个单位造成1点伤害。
		public DimunWarship(IGwentServerGame game, GameCard card) : base(game, card){}
		public override async Task<int> CardPlayEffect(bool isSpying)
		{
			return 0;
		}
	}
}