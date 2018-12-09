using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DungeonDice.Models
{
    public abstract class Creature
    {
        public enum CreatureType { Aberration, Animal, Construct, Dragon, Fey,
            Humanoid, MagicalBeast, MonstrousHumanoid, Ooze, Outsider, Plant,
            Undead, Vermin }
        public enum Alignment { LawfulGood, NeutralGood, ChaoticGood,
            LawfulNeutral, TrueNeutral, ChaoticNeutral, LawfulEvil,
            NeutralEvil, ChaoticEvil }
        public enum Size { Fine, Diminutive, Tiny, Small, Medium,
            Large, Huge, Gargantuan, Colossal }

        public int MaxHitPoints { get; set; }
        public int CurrentHitPoints { get; set; }

        public int? Strength { get; set; }
        public int? StrModifier { get; set; }

        public int? Dexterity { get; set; }
        public int? DexModifier { get; set; }

        public int? Constitution { get; set; }
        public int? ConModifier { get; set; }

        public int? Intelligence { get; set; }
        public int? IntModifier { get; set; }

        public int? Wisdom { get; set; }
        public int? WisModifier { get; set; }

        public int? Charisma { get; set; }
        public int? ChaModifier { get; set; }

        public int InitiativeModifier { get; set; }
        public int Speed { get; set; }
        public int FortModifier { get; set; }
        public int RefModifier { get; set; }
        public int WillModifier { get; set; }

        public Attack()
        {

        }

        public int BaseAttackBonus { get; set; }
        public int CombatManeuverBonus { get; set; }
        public int CombatManeuverDefense { get; set; }
        public int ArmorClass { get; set; }
        public int TouchArmorClass { get; set; }
        public int FlatFootedArmorClass { get; set; }

        public string[] Feats { get; set; }
        public string[] Languages { get; set; }
        public class Skills
        {
            public int AcrobaticsSkillRank { get; set; }
            public int AcrobaticsSkillModifier { get; set; }

            public int AppraiseSkillRank { get; set; }
            public int AppraiseSkillModifier { get; set; }

            public int BluffSkillRank { get; set; }
            public int BluffSkillModifier { get; set; }

            public int ClimbSkillRank { get; set; }
            public int ClimbSkillModifier { get; set; }

            public int CraftSkillRank { get; set; }
            public int CraftSkillModifier { get; set; }

            public int DiplomacySkillRank { get; set; }
            public int DiplomacySkillModifier { get; set; }

            public int DisableDeviceSkillRank { get; set; }
            public int DisableDeviceSkillModifier { get; set; }

            public int DisguiseSkillRank { get; set; }
            public int DisguiseSkillModifier { get; set; }

            public int EscapeArtistSkillRank { get; set; }
            public int EscapeArtistSkillModifier { get; set; }

            public int FlySkillRank { get; set; }
            public int FlySkillModifier { get; set; }

            public int HandleAnimalSkillRank { get; set; }
            public int HandleAnimalSkillModifier { get; set; }

            public int HealSkillRank { get; set; }
            public int HealSkillModifier { get; set; }

            public int IntimidateSkillRank { get; set; }
            public int IntimidateSkillModifier { get; set; }

            public int KnowledgeArcanaSkillRank { get; set; }
            public int KnowledgeArcanaSkillModifier { get; set; }

            public int KnowledgeDungeoneeringSkillRank { get; set; }
            public int KnowledgeDungeoneeringSkillModifier { get; set; }

            public int KnowledgeEngineeringSkillRank { get; set; }
            public int KnowledgeEngineeringSkillModifier { get; set; }

            public int KnowledgeGeographySkillRank { get; set; }
            public int KnowledgeGeographySkillModifier { get; set; }

            public int KnowledgeHistorySkillRank { get; set; }
            public int KnowledgeHistorySkillModifier { get; set; }

            public int KnowledgeLocalSkillRank { get; set; }
            public int KnowledgeLocalSkillModifier { get; set; }

            public int KnowledgeNatureSkillRank { get; set; }
            public int KnowledgeNatureSkillModifier { get; set; }

            public int KnowledgeNobilitySkillRank { get; set; }
            public int KnowledgeNobilitySkillModifier { get; set; }

            public int KnowledgePlanesSkillRank { get; set; }
            public int KnowledgePlanesSkillModifier { get; set; }

            public int KnowledgeReligionSkillRank { get; set; }
            public int KnowledgeReligionSkillModifier { get; set; }

            public int LinguisticsSkillRank { get; set; }
            public int LinguisticsSkillModifier { get; set; }

            public int PerceptionSkillRank { get; set; }
            public int PerceptionSkillModifier { get; set; }

            public int PerformSkillRank { get; set; }
            public int PerformSkillModifier { get; set; }

            public int ProfessionSkillRank { get; set; }
            public int ProfessionSkillModifier { get; set; }

            public int RideSkillRank { get; set; }
            public int RideSkillModifier { get; set; }

            public int SenseMotiveSkillRank { get; set; }
            public int SenseMotiveSkillModifier { get; set; }

            public int SleightOfHandSkillRank { get; set; }
            public int SleightOfHandSkillModifier { get; set; }

            public int SpellcraftSkillRank { get; set; }
            public int SpellcraftSkillModifier { get; set; }

            public int StealthSkillRank { get; set; }
            public int StealthSkillModifier { get; set; }

            public int SurvivalSkillRank { get; set; }
            public int SurvivalSkillModifier { get; set; }

            public int SwimSkillRank { get; set; }
            public int SwimSkillModifier { get; set; }

            public int UseMagicDeviceSkillRank { get; set; }
            public int UseMagicDeviceSkillModifier { get; set; }
        }

        public string[] Senses { get; set; }
        public string[] SpecialQualities { get; set; }
        public string[] Inventory { get; set; }

    }
}