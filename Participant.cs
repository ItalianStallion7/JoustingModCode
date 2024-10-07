using System;
using System.Linq;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.TournamentGames;
using TaleWorlds.Core;

namespace LogRaamJousting.Decoupling
{
	// Token: 0x0200003E RID: 62
	public class Participant
	{
		// Token: 0x06000191 RID: 401 RVA: 0x00009340 File Offset: 0x00007540
		public Participant(ref TournamentParticipant participant)
		{
			this._participant = participant;
			this._matchEquipment = this._participant.MatchEquipment;
			this._level = participant.Character.Level;
			bool flag = participant.Character.HeroObject != null;
			if (flag)
			{
				this._isFactionLeader = participant.Character.HeroObject.IsFactionLeader;
			}
			this._isLord = participant.Character.Occupation == 3;
			this._isPlayer = participant.IsPlayer;
			this._culture = participant.Character.Culture.GetCultureCode().ToString();
			this._isSoldier = participant.Character.Occupation == 7;
			this._isWanderer = participant.Character.Occupation == 16;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000941C File Offset: 0x0000761C
		public Participant()
		{
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00009428 File Offset: 0x00007628
		// (set) Token: 0x06000194 RID: 404 RVA: 0x0000949B File Offset: 0x0000769B
		public string Culture
		{
			get
			{
				CampaignState state = new CampaignState();
				bool flag = this._participant.Character.Culture == null;
				string text;
				if (flag)
				{
					text = this._culture;
				}
				else
				{
					text = ((state.GameStarted() || state.CampaignStarted()) ? this._participant.Character.Culture.GetCultureCode().ToString() : this._culture);
				}
				return text;
			}
			set
			{
				this._culture = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000195 RID: 405 RVA: 0x000094A4 File Offset: 0x000076A4
		// (set) Token: 0x06000196 RID: 406 RVA: 0x0000950D File Offset: 0x0000770D
		public bool IsFactionLeader
		{
			get
			{
				CampaignState state = new CampaignState();
				bool flag = !state.GameStarted() && !state.CampaignStarted();
				bool flag2;
				if (flag)
				{
					flag2 = this._isFactionLeader;
				}
				else
				{
					bool flag3 = this._participant.Character.HeroObject == null;
					flag2 = !flag3 && this._participant.Character.HeroObject.IsFactionLeader;
				}
				return flag2;
			}
			set
			{
				this._isFactionLeader = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00009518 File Offset: 0x00007718
		// (set) Token: 0x06000198 RID: 408 RVA: 0x00009558 File Offset: 0x00007758
		public bool IsHero
		{
			get
			{
				CampaignState state = new CampaignState();
				return (state.GameStarted() || state.CampaignStarted()) ? this._participant.Character.IsHero : this._isHero;
			}
			set
			{
				this._isHero = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000199 RID: 409 RVA: 0x00009564 File Offset: 0x00007764
		// (set) Token: 0x0600019A RID: 410 RVA: 0x000095A7 File Offset: 0x000077A7
		public bool IsLord
		{
			get
			{
				CampaignState state = new CampaignState();
				return (state.GameStarted() || state.CampaignStarted()) ? (this._participant.Character.Occupation == 3) : this._isLord;
			}
			set
			{
				this._isLord = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600019B RID: 411 RVA: 0x000095B0 File Offset: 0x000077B0
		// (set) Token: 0x0600019C RID: 412 RVA: 0x000095EB File Offset: 0x000077EB
		public bool IsPlayer
		{
			get
			{
				CampaignState state = new CampaignState();
				return (state.GameStarted() || state.CampaignStarted()) ? this._participant.IsPlayer : this._isPlayer;
			}
			set
			{
				this._isPlayer = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600019D RID: 413 RVA: 0x000095F4 File Offset: 0x000077F4
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00009637 File Offset: 0x00007837
		public bool IsSoldier
		{
			get
			{
				CampaignState state = new CampaignState();
				return (state.GameStarted() || state.CampaignStarted()) ? (this._participant.Character.Occupation == 7) : this._isSoldier;
			}
			set
			{
				this._isSoldier = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00009640 File Offset: 0x00007840
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00009684 File Offset: 0x00007884
		public bool IsWanderer
		{
			get
			{
				CampaignState state = new CampaignState();
				return (state.GameStarted() || state.CampaignStarted()) ? (this._participant.Character.Occupation == 16) : this._isWanderer;
			}
			set
			{
				this._isWanderer = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00009690 File Offset: 0x00007890
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x000096D0 File Offset: 0x000078D0
		public int Level
		{
			get
			{
				CampaignState state = new CampaignState();
				return (state.GameStarted() || state.CampaignStarted()) ? this._participant.Character.Level : this._level;
			}
			set
			{
				this._level = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000096D9 File Offset: 0x000078D9
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x000096E4 File Offset: 0x000078E4
		public Equipment MatchEquipment
		{
			get
			{
				return this._matchEquipment;
			}
			set
			{
				CampaignState state = new CampaignState();
				bool flag = state.GameStarted() || state.CampaignStarted();
				if (flag)
				{
					this._participant.MatchEquipment = this._matchEquipment;
				}
				this._matchEquipment = value;
			}
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00009728 File Offset: 0x00007928
		public Equipment GetBattleEquipments()
		{
			CampaignState state = new CampaignState();
			bool flag = state.GameStarted() && state.CampaignStarted();
			Equipment equipment;
			if (flag)
			{
				equipment = this.RefToGameParticipant().Character.BattleEquipments.First<Equipment>();
			}
			else
			{
				equipment = new Equipment();
			}
			return equipment;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00009774 File Offset: 0x00007974
		public TournamentParticipant RefToGameParticipant()
		{
			bool flag = this._participant == null;
			TournamentParticipant tournamentParticipant;
			if (flag)
			{
				tournamentParticipant = new TournamentParticipant(new CharacterObject(), default(UniqueTroopDescriptor));
			}
			else
			{
				tournamentParticipant = this._participant;
			}
			return tournamentParticipant;
		}

		// Token: 0x0400009C RID: 156
		private readonly TournamentParticipant _participant;

		// Token: 0x0400009D RID: 157
		private string _culture;

		// Token: 0x0400009E RID: 158
		private bool _isFactionLeader;

		// Token: 0x0400009F RID: 159
		private bool _isHero;

		// Token: 0x040000A0 RID: 160
		private bool _isLord;

		// Token: 0x040000A1 RID: 161
		private bool _isPlayer;

		// Token: 0x040000A2 RID: 162
		private bool _isSoldier;

		// Token: 0x040000A3 RID: 163
		private bool _isWanderer;

		// Token: 0x040000A4 RID: 164
		private int _level;

		// Token: 0x040000A5 RID: 165
		private Equipment _matchEquipment;
	}
}
