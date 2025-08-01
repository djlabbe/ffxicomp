using FFXIComp.Api.Models;

namespace FFXIComp.Api.SeedData
{
    public static class Hands3SeedData
    {
        public static List<GearItem> GetItems()
        {
            return new List<GearItem>
            {
                new GearItem
                {
                    Name = "Peltast's Vambraces +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 82 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 47 },
                        new GearStat { Name = "Vit", Value = 47 },
                        new GearStat { Name = "Agi", Value = 22 },
                        new GearStat { Name = "Int", Value = 21 },
                        new GearStat { Name = "Mnd", Value = 39 },
                        new GearStat { Name = "Chr", Value = 30 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "Attack", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DA", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Peltast's Vambraces +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvasion", Value = 72 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 19 },
                        new GearStat { Name = "Dex", Value = 42 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 16 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "DA", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DRG" } }
                },
                new GearItem
                {
                    Name = "Ayanmo Manopolas +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 19 },
                        new GearStat { Name = "MagicEvasion", Value = 37 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "DT", Value = -3 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 53 },
                        new GearStat { Name = "Vit", Value = 30 },
                        new GearStat { Name = "Agi", Value = 11 },
                        new GearStat { Name = "Int", Value = 14 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 19 },
                        new GearStat { Name = "Accuracy", Value = 43 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "EnSpellDamage", Value = 17 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Gazu Bracelets +1 R15",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 22 },
                        new GearStat { Name = "MagicEvasion", Value = 43 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 42 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 39 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 94 },
                        new GearStat { Name = "Attack", Value = -17 },
                        new GearStat { Name = "GearHaste", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "WHM" }, new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Arbatel Bracers +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 98 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 40 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 36 },
                        new GearStat { Name = "Mnd", Value = 47 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "MagicAttack", Value = 52 },
                        new GearStat { Name = "MagicDamage", Value = 32 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 15 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SCH" } }
                },
                new GearItem
                {
                    Name = "Arbatel Bracers +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 59 },
                        new GearStat { Name = "MagicEvasion", Value = 88 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 33 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 31 },
                        new GearStat { Name = "Mnd", Value = 42 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "MagicAttack", Value = 47 },
                        new GearStat { Name = "MagicDamage", Value = 32 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "MagicBurstDamage", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SCH" } }
                },
                new GearItem
                {
                    Name = "Boii Mufflers +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 82 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 47 },
                        new GearStat { Name = "Vit", Value = 47 },
                        new GearStat { Name = "Agi", Value = 22 },
                        new GearStat { Name = "Int", Value = 21 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "Attack", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "AxeSkill", Value = 31 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Boii Mufflers +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvasion", Value = 72 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 19 },
                        new GearStat { Name = "Dex", Value = 42 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 16 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "AxeSkill", Value = 26 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" } }
                },
                new GearItem
                {
                    Name = "Kasuga Kote +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 82 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 24 },
                        new GearStat { Name = "Dex", Value = 47 },
                        new GearStat { Name = "Vit", Value = 47 },
                        new GearStat { Name = "Agi", Value = 23 },
                        new GearStat { Name = "Int", Value = 21 },
                        new GearStat { Name = "Mnd", Value = 39 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "Attack", Value = 62 },
                        new GearStat { Name = "RangedAccuracy", Value = 62 },
                        new GearStat { Name = "RangedAttack", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Kasuga Kote +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvasion", Value = 72 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 19 },
                        new GearStat { Name = "Dex", Value = 42 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 18 },
                        new GearStat { Name = "Int", Value = 16 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 52 },
                        new GearStat { Name = "RangedAccuracy", Value = 52 },
                        new GearStat { Name = "RangedAttack", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "SAM" } }
                },
                new GearItem
                {
                    Name = "Chasseur's Gants +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 77 },
                        new GearStat { Name = "MagicEvasion", Value = 93 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 49 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 23 },
                        new GearStat { Name = "Mnd", Value = 44 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "RangedAccuracy", Value = 62 },
                        new GearStat { Name = "RangedAttack", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 8 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Chasseur's Gants +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 67 },
                        new GearStat { Name = "MagicEvasion", Value = 83 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 33 },
                        new GearStat { Name = "Agi", Value = 21 },
                        new GearStat { Name = "Int", Value = 18 },
                        new GearStat { Name = "Mnd", Value = 39 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "RangedAccuracy", Value = 52 },
                        new GearStat { Name = "RangedAttack", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "CritRate", Value = 7 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 8 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Fili Manchettes +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 93 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 36 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 29 },
                        new GearStat { Name = "Mnd", Value = 47 },
                        new GearStat { Name = "Chr", Value = 39 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Fili Manchettes +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvasion", Value = 83 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 31 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 24 },
                        new GearStat { Name = "Mnd", Value = 42 },
                        new GearStat { Name = "Chr", Value = 34 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BRD" } }
                },
                new GearItem
                {
                    Name = "Carmine Finger Gauntlets +1 D",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 22 },
                        new GearStat { Name = "MagicEvasion", Value = 43 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "Str", Value = 10 },
                        new GearStat { Name = "Dex", Value = 33 },
                        new GearStat { Name = "Vit", Value = 32 },
                        new GearStat { Name = "Agi", Value = 12 },
                        new GearStat { Name = "Int", Value = 14 },
                        new GearStat { Name = "Mnd", Value = 32 },
                        new GearStat { Name = "Chr", Value = 23 },
                        new GearStat { Name = "RangedAttack", Value = 58 },
                        new GearStat { Name = "MagicAttack", Value = 42 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "RUN" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "COR" } }
                },
                new GearItem
                {
                    Name = "Meghanada Gloves +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 36 },
                        new GearStat { Name = "MagicEvasion", Value = 37 },
                        new GearStat { Name = "MagicDefense", Value = 2 },
                        new GearStat { Name = "PDT", Value = -4 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 50 },
                        new GearStat { Name = "Vit", Value = 29 },
                        new GearStat { Name = "Agi", Value = 19 },
                        new GearStat { Name = "Int", Value = 11 },
                        new GearStat { Name = "Mnd", Value = 34 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 47 },
                        new GearStat { Name = "Attack", Value = 43 },
                        new GearStat { Name = "RangedAccuracy", Value = 47 },
                        new GearStat { Name = "RangedAttack", Value = 43 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "WeaponSkillDamage", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Oshosi Gloves +1",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 47 },
                        new GearStat { Name = "MagicEvasion", Value = 79 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 5 },
                        new GearStat { Name = "Int", Value = 11 },
                        new GearStat { Name = "Mnd", Value = 29 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "RangedAccuracy", Value = 44 },
                        new GearStat { Name = "MagicAccuracy", Value = 49 },
                        new GearStat { Name = "DoubleShot", Value = 5 },
                        new GearStat { Name = "TripleShot", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Skulker's Armlets +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 86 },
                        new GearStat { Name = "MagicEvasion", Value = 93 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 53 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 27 },
                        new GearStat { Name = "Int", Value = 22 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "Attack", Value = 72 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "SneakAttackBonus", Value = 30 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Skulker's Armlets +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 76 },
                        new GearStat { Name = "MagicEvasion", Value = 83 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 48 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 22 },
                        new GearStat { Name = "Int", Value = 17 },
                        new GearStat { Name = "Mnd", Value = 35 },
                        new GearStat { Name = "Chr", Value = 22 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "SneakAttackBonus", Value = 28 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" } }
                },
                new GearItem
                {
                    Name = "Bhikku Gloves +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 82 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 49 },
                        new GearStat { Name = "Vit", Value = 45 },
                        new GearStat { Name = "Agi", Value = 21 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 42 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "Attack", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "HandtoHandSkill", Value = 21 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "PDL", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Bhikku Gloves +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvasion", Value = 72 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "HandtoHandSkill", Value = 16 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "PDL", Value = 7 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "MNK" } }
                },
                new GearItem
                {
                    Name = "Maculele Bangles +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 96 },
                        new GearStat { Name = "MagicEvasion", Value = 83 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 53 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 27 },
                        new GearStat { Name = "Int", Value = 23 },
                        new GearStat { Name = "Mnd", Value = 41 },
                        new GearStat { Name = "Chr", Value = 28 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "Attack", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 13 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Maculele Bangles +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 86 },
                        new GearStat { Name = "MagicEvasion", Value = 73 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 48 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 22 },
                        new GearStat { Name = "Int", Value = 18 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 23 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "SkillchainBonus", Value = 12 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "DNC" } }
                },
                new GearItem
                {
                    Name = "Nukumi Manoplas +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 82 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 25 },
                        new GearStat { Name = "Dex", Value = 48 },
                        new GearStat { Name = "Vit", Value = 47 },
                        new GearStat { Name = "Agi", Value = 22 },
                        new GearStat { Name = "Int", Value = 21 },
                        new GearStat { Name = "Mnd", Value = 38 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "Attack", Value = 72 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Nukumi Manoplas +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvasion", Value = 72 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 20 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 42 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 16 },
                        new GearStat { Name = "Mnd", Value = 33 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "CritRate", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BST" } }
                },
                new GearItem
                {
                    Name = "Azimuth Gloves +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 98 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "DT", Value = -12 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 40 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 20 },
                        new GearStat { Name = "Int", Value = 36 },
                        new GearStat { Name = "Mnd", Value = 47 },
                        new GearStat { Name = "Chr", Value = 32 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "MagicAttack", Value = 52 },
                        new GearStat { Name = "MagicDamage", Value = 32 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Azimuth Gloves +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 59 },
                        new GearStat { Name = "MagicEvasion", Value = 88 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Dex", Value = 35 },
                        new GearStat { Name = "Vit", Value = 33 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 31 },
                        new GearStat { Name = "Mnd", Value = 42 },
                        new GearStat { Name = "Chr", Value = 27 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "MagicAttack", Value = 47 },
                        new GearStat { Name = "MagicDamage", Value = 22 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Chevalier's Gauntlets +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 69 },
                        new GearStat { Name = "MagicEvasion", Value = 98 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 27 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 54 },
                        new GearStat { Name = "Agi", Value = 0 },
                        new GearStat { Name = "Int", Value = 21 },
                        new GearStat { Name = "Mnd", Value = 36 },
                        new GearStat { Name = "Chr", Value = 31 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "Attack", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "SwordSkill", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Chevalier's Gauntlets +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 59 },
                        new GearStat { Name = "MagicEvasion", Value = 88 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 22 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 49 },
                        new GearStat { Name = "Agi", Value = 0 },
                        new GearStat { Name = "Int", Value = 16 },
                        new GearStat { Name = "Mnd", Value = 31 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "SwordSkill", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PLD" } }
                },
                new GearItem
                {
                    Name = "Amini Glovelettes +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 77 },
                        new GearStat { Name = "MagicEvasion", Value = 93 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 28 },
                        new GearStat { Name = "Dex", Value = 49 },
                        new GearStat { Name = "Vit", Value = 38 },
                        new GearStat { Name = "Agi", Value = 26 },
                        new GearStat { Name = "Int", Value = 23 },
                        new GearStat { Name = "Mnd", Value = 44 },
                        new GearStat { Name = "Chr", Value = 26 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "RangedAccuracy", Value = 62 },
                        new GearStat { Name = "RangedAttack", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "ArcherySkill", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Amini Glovelettes +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 67 },
                        new GearStat { Name = "MagicEvasion", Value = 83 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 23 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 33 },
                        new GearStat { Name = "Agi", Value = 21 },
                        new GearStat { Name = "Int", Value = 18 },
                        new GearStat { Name = "Mnd", Value = 39 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "RangedAccuracy", Value = 52 },
                        new GearStat { Name = "RangedAttack", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "ArcherySkill", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 10 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RNG" } }
                },
                new GearItem
                {
                    Name = "Erilaz Gauntlets +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 78 },
                        new GearStat { Name = "MagicEvasion", Value = 87 },
                        new GearStat { Name = "MagicDefense", Value = 7 },
                        new GearStat { Name = "DT", Value = -11 },
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 47 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 17 },
                        new GearStat { Name = "Int", Value = 26 },
                        new GearStat { Name = "Mnd", Value = 45 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "Attack", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "GreatSwordSkill", Value = 38 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Erilaz Gauntlets +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 68 },
                        new GearStat { Name = "MagicEvasion", Value = 77 },
                        new GearStat { Name = "MagicDefense", Value = 6 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 42 },
                        new GearStat { Name = "Vit", Value = 35 },
                        new GearStat { Name = "Agi", Value = 12 },
                        new GearStat { Name = "Int", Value = 21 },
                        new GearStat { Name = "Mnd", Value = 40 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "GreatSwordSkill", Value = 33 },
                        new GearStat { Name = "GearHaste", Value = 5 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Karagoz Guanti +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 26 },
                        new GearStat { Name = "Dex", Value = 49 },
                        new GearStat { Name = "Vit", Value = 45 },
                        new GearStat { Name = "Agi", Value = 21 },
                        new GearStat { Name = "Int", Value = 20 },
                        new GearStat { Name = "Mnd", Value = 42 },
                        new GearStat { Name = "Chr", Value = 25 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "Attack", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "Evasion", Value = 74 },
                        new GearStat { Name = "MagicEvasion", Value = 82 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 11 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Pet:Str", Value = 26 },
                        new GearStat { Name = "Pet:Dex", Value = 26 },
                        new GearStat { Name = "Pet:Agi", Value = 26 },
                        new GearStat { Name = "Pet:Accuracy", Value = 62 },
                        new GearStat { Name = "Pet:RangedAccuracy", Value = 62 },
                        new GearStat { Name = "Pet:MagicAccuracy", Value = 62 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Karagoz Guanti +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 21 },
                        new GearStat { Name = "Dex", Value = 44 },
                        new GearStat { Name = "Vit", Value = 40 },
                        new GearStat { Name = "Agi", Value = 16 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 20 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "Evasion", Value = 64 },
                        new GearStat { Name = "MagicEvasion", Value = 72 },
                        new GearStat { Name = "MagicDefense", Value = 4 },
                        new GearStat { Name = "GearHaste", Value = 5 },
                        new GearStat { Name = "StoreTP", Value = 10 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Pet:Str", Value = 21 },
                        new GearStat { Name = "Pet:Dex", Value = 21 },
                        new GearStat { Name = "Pet:Agi", Value = 21 },
                        new GearStat { Name = "Pet:Accuracy", Value = 52 },
                        new GearStat { Name = "Pet:RangedAccuracy", Value = 52 },
                        new GearStat { Name = "Pet:MagicAccuracy", Value = 52 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "PUP" } }
                },
                new GearItem
                {
                    Name = "Hashishin Bazubands +3",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 77 },
                        new GearStat { Name = "MagicEvasion", Value = 87 },
                        new GearStat { Name = "MagicDefense", Value = 10 },
                        new GearStat { Name = "DT", Value = -10 },
                        new GearStat { Name = "Str", Value = 16 },
                        new GearStat { Name = "Dex", Value = 43 },
                        new GearStat { Name = "Vit", Value = 39 },
                        new GearStat { Name = "Agi", Value = 15 },
                        new GearStat { Name = "Int", Value = 33 },
                        new GearStat { Name = "Mnd", Value = 50 },
                        new GearStat { Name = "Chr", Value = 29 },
                        new GearStat { Name = "Accuracy", Value = 62 },
                        new GearStat { Name = "Attack", Value = 62 },
                        new GearStat { Name = "MagicAccuracy", Value = 62 },
                        new GearStat { Name = "MagicAttack", Value = 57 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Hashishin Bazubands +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Evasion", Value = 67 },
                        new GearStat { Name = "MagicDefense", Value = 9 },
                        new GearStat { Name = "DT", Value = -9 },
                        new GearStat { Name = "Str", Value = 11 },
                        new GearStat { Name = "Dex", Value = 38 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 10 },
                        new GearStat { Name = "Int", Value = 28 },
                        new GearStat { Name = "Mnd", Value = 45 },
                        new GearStat { Name = "Chr", Value = 24 },
                        new GearStat { Name = "Accuracy", Value = 52 },
                        new GearStat { Name = "Attack", Value = 52 },
                        new GearStat { Name = "MagicAccuracy", Value = 52 },
                        new GearStat { Name = "MagicAttack", Value = 52 },
                        new GearStat { Name = "GearHaste", Value = 3 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLU" } }
                },
                new GearItem
                {
                    Name = "Volte Mittens",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 29 },
                        new GearStat { Name = "Dex", Value = 55 },
                        new GearStat { Name = "Vit", Value = 23 },
                        new GearStat { Name = "Agi", Value = 24 },
                        new GearStat { Name = "Int", Value = 6 },
                        new GearStat { Name = "Mnd", Value = 17 },
                        new GearStat { Name = "Chr", Value = 16 },
                        new GearStat { Name = "Accuracy", Value = 36 },
                        new GearStat { Name = "RangedAccuracy", Value = 36 },
                        new GearStat { Name = "Evasion", Value = 70 },
                        new GearStat { Name = "MagicEvasion", Value = 43 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "GearHaste", Value = 4 },
                        new GearStat { Name = "StoreTP", Value = 6 },
                        new GearStat { Name = "SubtleBlow", Value = 6 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "WAR" }, new GearItemJob { JobName = "MNK" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "PLD" }, new GearItemJob { JobName = "DRK" }, new GearItemJob { JobName = "BST" }, new GearItemJob { JobName = "BRD" }, new GearItemJob { JobName = "RNG" }, new GearItemJob { JobName = "SAM" }, new GearItemJob { JobName = "NIN" }, new GearItemJob { JobName = "DRG" }, new GearItemJob { JobName = "BLU" }, new GearItemJob { JobName = "COR" }, new GearItemJob { JobName = "PUP" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                },
                new GearItem
                {
                    Name = "Mallquis Cuffs +2",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 3 },
                        new GearStat { Name = "Dex", Value = 23 },
                        new GearStat { Name = "Vit", Value = 34 },
                        new GearStat { Name = "Agi", Value = 2 },
                        new GearStat { Name = "Int", Value = 40 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "MagicAccuracy", Value = 43 },
                        new GearStat { Name = "MagicDamage", Value = 49 },
                        new GearStat { Name = "Evasion", Value = 19 },
                        new GearStat { Name = "MagicEvasion", Value = 48 },
                        new GearStat { Name = "MagicAttack", Value = 15 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Merlinic Dastanas (Occult Acumen)",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 3 },
                        new GearStat { Name = "Dex", Value = 23 },
                        new GearStat { Name = "Vit", Value = 20 },
                        new GearStat { Name = "Agi", Value = 2 },
                        new GearStat { Name = "Int", Value = 26 },
                        new GearStat { Name = "Mnd", Value = 37 },
                        new GearStat { Name = "Chr", Value = 21 },
                        new GearStat { Name = "Evasion", Value = 19 },
                        new GearStat { Name = "MagicEvasion", Value = 48 },
                        new GearStat { Name = "MagicDefense", Value = 3 },
                        new GearStat { Name = "GearHaste", Value = 3 },
                        new GearStat { Name = "OccultAcumen", Value = 11 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "BLM" }, new GearItemJob { JobName = "RDM" }, new GearItemJob { JobName = "SMN" }, new GearItemJob { JobName = "SCH" }, new GearItemJob { JobName = "GEO" } }
                },
                new GearItem
                {
                    Name = "Turms Mittens +1",
                    Slot = "Hands",
                    GearStats = new List<GearStat>
                    {
                        new GearStat { Name = "Str", Value = 12 },
                        new GearStat { Name = "Dex", Value = 51 },
                        new GearStat { Name = "Vit", Value = 32 },
                        new GearStat { Name = "Agi", Value = 5 },
                        new GearStat { Name = "Int", Value = 15 },
                        new GearStat { Name = "Mnd", Value = 30 },
                        new GearStat { Name = "Chr", Value = 23 },
                        new GearStat { Name = "Accuracy", Value = 49 },
                        new GearStat { Name = "Evasion", Value = 80 },
                        new GearStat { Name = "MagicEvasion", Value = 101 },
                        new GearStat { Name = "MagicDefense", Value = 5 },
                        new GearStat { Name = "GearHaste", Value = 4 }
                    },
                    GearItemJobs = new List<GearItemJob> { new GearItemJob { JobName = "THF" }, new GearItemJob { JobName = "DNC" }, new GearItemJob { JobName = "RUN" } }
                }
            };
        }
    }
}
