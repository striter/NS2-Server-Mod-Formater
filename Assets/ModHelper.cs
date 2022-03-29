using System.Linq;
using System.Text;
using UnityEngine;

public class ModHelper : MonoBehaviour
{
    private void OnValidate()
    {
        StringBuilder totalMods = new StringBuilder();
        StringBuilder mapCycle = new StringBuilder();
        totalMods.AppendMod(KMods.kCommon);
        
        StringBuilder commonCycle = new StringBuilder();
        commonCycle.AppendMapCycle(KMods.kCommon,true,true);
        Debug.Log("All Common:\n"+commonCycle);
        
        //PVP
        Debug.LogError("Standard:");
        
        mapCycle.Append("\n"+Helper.CreateMapMode(KMods.kBaseMaps.Concat(KMods.KPVP.kCustomMaps).ToArray(), 
            KMods.kNSBase)    
        );
        
        mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KCombat.kMaps,
            KMods.KCombat.kBase,
            KMods.kNSBase,
            KMods.kNSExtend1)
        );
        
        mapCycle.Append("\n" + Helper.CreateMapMode(KMods.KInfested.kMaps, 
            KMods.KInfested.kBase));
        
        
        mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KGungame.kMaps, 
            KMods.KGungame.kBase
        ));
        
        mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KGorgeRun.kMaps, 
            KMods.KGorgeRun.kBase));

        mapCycle.Append("\n" + Helper.CreateMapMode(KMods.KDefense.kMaps, 
            KMods.KDefense.kBase));
        
        Debug.LogWarning("Map Cycle:"+mapCycle);
        
        commonCycle.Clear();
        commonCycle.AppendMapCycle(KMods.kCommon,true);
        commonCycle.AppendMapCycle(KMods.kPlaygroundCommon,false,true);
        Debug.Log("Playground Common:\n"+commonCycle);
        // Playground
        Debug.LogError("Playground Large:");
        mapCycle.Append(Helper.CreateMapMode(KMods.kBaseMaps.Concat(KMods.kCustommaps).Concat(KMods.kTowMaps).ToArray(),
            KMods.kNSBase,
            KMods.kNSExtend1,
            // KMods.kNSExtend,
            KMods.kLarge));
        

        Debug.Log("MapCycle 1:\n"+mapCycle);

        mapCycle.Clear();
        mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KSiege.kNormalmaps, 
            KMods.KSiege.kBase,
            KMods.kLarge,
            KMods.kNSBase,
            KMods.kNSExtend1
            ));
        
        mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KSiege.kLargeMaps, 
            KMods.kNSBase,
            KMods.kLarge,
            KMods.KSiege.kBase,
            KMods.kNSExtend1
        ));

        mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KCombat.kMaps, 
            KMods.KCombat.kBase,
            KMods.kNSBase,
            KMods.kNSExtend1
        ));
        
        mapCycle.Append("\n"+ Helper.CreateMapMode(KMods.kFiveMaps,
            KMods.kNSExtend1,
            KMods.KSentinel.kBase,
            KMods.KSentinel.kMods
        ));

        // mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KGungame.kMaps, 
        //     KMods.KGungame.kBase));
        
        // mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KSkulkWithShotgun.kMaps, 
        //     KMods.KSkulkWithShotgun.kBase));
        //
        // mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KLastStand.kMaps, 
        //     KMods.KLastStand.kBase));
        
        mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KInfested.kMaps, 
            KMods.KInfested.kBase
            )
        );
        
        mapCycle.Append("\n" + Helper.CreateMapMode(
            KMods.KDefense.kMaps, 
            KMods.KDefense.kBase));
        Debug.Log("MapCycle 2:"+mapCycle);

        mapCycle.Clear();
        Debug.LogError("3# Range:");
        totalMods.AppendMod(KMods.kCommon);
        totalMods.AppendMod(KMods.KSentinel.kBase);
        totalMods.AppendMod(KMods.KSentinel.kMods,true);
        
        mapCycle.AppendMapCycle(KMods.kCommon,true);
        mapCycle.AppendMapCycle(KMods.KSentinel.kBase,false,true);
        Debug.LogWarning("Total Mods:\n"+totalMods+"\n"+mapCycle);
        Debug.LogWarning("Map Cycle:\n"+Helper.CreateMapMode(KMods.kShootingRangeMaps, null));

        mapCycle.Clear();
        
        //Playground 
        Debug.LogError("4# Playground:");
        
        mapCycle.Append("\n"+Helper.CreateMapMode(KMods.kBaseMaps.Concat(KMods.kCustommaps).Concat(KMods.kFiveMaps).Concat(KMods.kTowMaps).ToArray(), 
            KMods.kPlayground,
            KMods.kNSBase)
            );
        
        mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KCombat.kMaps,
            KMods.KCombat.kBase,
            KMods.kNSBase,
            KMods.kNSExtend1)
            );

        // mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KSiege.kNormalmaps, 
        //     KMods.KSiege.kBase,
        //     KMods.kLarge,
        //     KMods.kPlayground,
        //     KMods.kNSBase,
        //     KMods.kNSExtend1
        //     ));
        
        // mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KSkulkWithShotgun.kMaps, 
        //     KMods.KSkulkWithShotgun.kBase));
        //
        // mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KLastStand.kMaps, 
        //     KMods.KLastStand.kBase));
        
        mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KGungame.kMaps, 
            KMods.KGungame.kBase
        ));

        mapCycle.Append("\n" + Helper.CreateMapMode(KMods.KInfested.kMaps,
            KMods.KInfested.kBase
        ));
        
        mapCycle.Append("\n"+Helper.CreateMapMode(KMods.KGorgeRun.kMaps, 
            KMods.KGorgeRun.kBase));
        
        mapCycle.Append("\n" + Helper.CreateMapMode(KMods.KDefense.kMaps, 
            KMods.KDefense.kBase));
        
        
        Debug.LogWarning("Map Cycle:"+mapCycle);
        mapCycle.Clear();
        
    }
}

static class Helper
{
    public static void AppendMod(this StringBuilder builder, string[] _elements,bool last=false)
    {
        for (int i = 0; i < _elements.Length; i++)
        {
            builder.Append(_elements[i]);
            if(last&&i==_elements.Length-1)
                continue;
            builder.Append(' ');
        }
    }
    public static void AppendMod(this StringBuilder builder, (string name,string hex)[] _elements,bool last=false)
    {
        for (int i = 0; i < _elements.Length; i++)
        {
            if (_elements[i].hex==null)
                continue;
            
            builder.Append(_elements[i].hex);
            if(last&&i==_elements.Length-1)
                continue;
            builder.Append(' ');
        }
    }
    public static void AppendMapCycle(this StringBuilder builder, string[] _elements,bool first=false,bool last=false)
    {
        if(first)
            builder.Append('"');
        for (int i = 0; i < _elements.Length; i++)
        {
            builder.Append(_elements[i]);
            if (last && i == _elements.Length - 1)
            {
                builder.Append('"');
                continue;
            }

            builder.Append('"');
            builder.Append(',');
            builder.Append('"');
        }
    }
    
    public static string CreateMapMode((string name,string hex)[] _maps,params string[][] mods)
    {
        StringBuilder totalMods = new StringBuilder();
        if (mods != null)
            for (int i = 0; i < mods.Length; i++)
                totalMods.AppendMapCycle(mods[i],i==0,i==mods.Length-1);
        
        StringBuilder builder=new StringBuilder();
        for (int i = 0; i < _maps.Length; i++)
        {
            var mapName = _maps[i].name;
            var mapMod = _maps[i].hex;
            string map = null;
            if (mods == null)
                map = $"?|map|: |{mapName}|,|mods|: [|{mapMod}|]!,";
            else if(mapMod!=null)
                map=$"?|map|: |{mapName}|, |mods|: [|{mapMod}|,{totalMods}]!,";
            else
                map=$"?|map|: |{mapName}|, |mods|: [{totalMods}]!,";
            map=map.Replace('?', '{');
            map=map.Replace('!', '}');
            map=map.Replace('|', '"');
            builder.Append(map);
            if (i != _maps.Length - 1)
                builder.Append("\n");
        }
        return builder.ToString();
    }
}

static class KMods
{
    // Common:
    // CN Chat Localization a21eccfa
    // CN Server Booting a164326a
    // CN Custom Voices a2e77430 
    // Shine Administrator 706d242
    // Shine Eplision c6fbbb0
    // TireInfo 72C5FD4E
    // Shine SwitchTeams? 626fc17b
    // Shine Rave? 2ec49e14
    // Ghoul 5b44c62c ?
    // Enhance Ragdoll? 7dac7a7e
    // Gorger Heart Heal Spray? 619984c
    public static readonly string[] kCommon =
        {"a26b1fd2","a164326a","a2e77430","706d242", "c6fbbb0", "72C5FD4E" };

    // CN Anti-Antihuman Tweak a113314b
    // CN Exosuit Boom Box a21f32d3
    public static readonly string[] kPlaygroundCommon =
        {"a113314b" ,"a21f32d3"};
    // M
    // Extra Weapons 99c77763
    // Revolver  99c779e7
    // Machinegun 99d33f34
    // Katana 9d145a23
    // Cannon 999838e9
    // ?Exosuit 9baf805e
    
    // A
    // Prowler 9805babe //Not supported
    // Gorger Toys 7B9B0165
    // Devour A3725A87
    // Personal Sentries 84f2921e
    
    public static readonly string[] kNSExtend1 = {"99c77763", "99c779e7", "99d33f34", "9d145a23", "7B9B0165","9805babe","999838e9","84F2921E","A3725A87"};

    //Fast Reaction Bot? 87908442 // Meanless
    //Scoreboard 9b55583a
    public static readonly string[] kNSBase = {"9b55583a"};
    
    //Rebirth Bot 8ae71fa2
    // RefundPres 75ce83cd
    public static readonly string[] kLarge = {"a0bd8c88"};
    
    //CN Playground Balance
    public static readonly string[] kPlayground = {"a474e602","8ae71fa2"};
    public static readonly (string name, string hex)[] kBaseMaps =
    {
        ("ns2_veil", null),
        ("ns2_biodome", null),
        ("ns2_caged", null),
        ("ns2_summit", null),
        ("ns2_tram", null),
        ("ns2_docking", null),
        ("ns2_descent", null),
        ("ns2_eclipse", null),
        ("ns2_derelict", null),
        ("ns2_kodiak", null),
        ("ns2_metro", null),
        ("ns2_mineshaft", null),
        ("ns2_refinery", null),
        ("ns2_unearthed", null),
        ("ns2_tanith", null),
        ("ns2_origin", null),
        
        ("ns2_dark","26130594"),
        ("ns2_nexus","17B0E28C"),
        ("ns2_ayumi", "98EE90A0"),
        ("ns2_hydra","13bceec3"),
        ("ns2_mineral_dev","83f489c7"),
        ("ns2_jambi_redux","6d45366f"),
        ("ns2_forgotten","136d050a"),
        ("ns2_nothing","d2b361d"),
        ("ns2_gorgon","16c11635"),
        ("ns2_triad","46F035A"),
    };
    
    public static readonly (string name, string hex)[] kCustommaps =
    {
        //Finished
        ("ns2_prison","4B905FD1"),
        ("ns2_forge","147B8E4B"),
        ("ns2_fusion","aaac676"),
        ("ns2_fracture","8f1b64d"),
        ("ns2_stag","266c0d1d"),
        ("ns2_Stratos","101b4e31"),
        ("ns2_spaceship_refined","7778d86f"),
        
        ("ns2_alterra", "7bf85e12"),
        ("ns2_patchwork", "78dc5c17"),
        ("ns2_turtle","486cef9"),
        ("ns2_temple","f5e1aef"),
        ("ns2_plant","546DEEF"),
        
        ("ns2_deburred","90720463"),
        ("ns2_TinCans_Station","1c9636c4"),
        ("ns2_light","ca31e28"),
        ("ns2_yana","a0d51e0"),

        // ("ns2_hera2018","5c6720cf"),
        // ("ns2_nancy2019","65e3b938"),        //Block Exos/Onos
    };
    
    public static readonly (string name,string hex)[] kTowMaps =
    {
        ("ns2_tow_summit", "ac3aca4"),
        ("ns2_tow_biodome", "3fb90249"),
        ("ns2_tow_refinery", "7c78d1b6"),
        ("ns2_tow_descent", "3a0a2cff"),
        ("ns2_tow_combi", "7c07b599"),
    };
    
    public static readonly (string name,string hex)[] kFiveMaps =
    {
        ("ns2_veil_five", "fdf2c56"),
        ("ns2_origin_five", "369bbc2a"),
        ("ns2_caged_five", "4bc78185"),
        ("ns2_eclipse_five", "391e2cdb"),
    };
    
    public static readonly (string name,string hex)[] kShootingRangeMaps =
    {
        ("ns2_range","51206919"),
        ("ns2_aim_pillars","13DC998A"),
    };
    public static class KCombat
    {
        // Combat 8AE61F8F
        // Shield Generator 45f1d75d

        public static readonly string[] kBase = {"8AE61F8F"};
        // public static readonly string[] kMods = {"45f1d75d"};
        public static readonly (string name,string hex)[] kMaps = {
            ("co_summit","4fd7fd4"),
            ("co_lavacliff","69d0883"),
            ("co_niveus", "8DE6CE2C"),
            ("co_daimos", "87B4CE2E"),
            ("co_kestrel", "92364B5D"),
            ("co_umbra", "a21ac749"),
            ("co_spacefall", "68b3b64e"),
            ("co_volcanodrop", "692d1e72"),
            ("co_core", "86B2ABA9"),
            ("co_angst", "91C78BE4"),
            ("co_nest","91CB4B9A"),
            ("co_sava","91C881E9"),
            ("co_pulse","91C81F8E"),
            ("co_pump","8605EFF7"),
            ("co_skyline","80D9BF14"),
            ("co_capacity","86D05BD6"),
            ("co_blackmesa","A03581A9"),
            // ("co_hellevator","781bc0e"),     //Error
            ("ns2_co_faceoff","4d41f11"),
            ("ns2_co_stargate","7caac9a"),
            ("ns2_co_fightbox","a42aa5a"),
            ("ns2_co_portals","8e07ac8"),
            ("ns2_co_skylight","7b92d88"),
            ("ns2_co_rats","81b8a195"),
            // ("ns2_co_spacejump","7bc2b15"),      //Jumppad won't work
        };
    }

    public static class KGungame
    {
        public static readonly string[] kBase = {"a499c1c2"};
        public static readonly (string name,string hex)[] kMaps =
        {
            ("gg_basic",null),
            ("gg_shelter",null),
            ("gg_pyramid",null),
            ("gg_match",null),
            ("gg_lego", null),
            ("gg_natus",null),
            ("gg_mario",null),
        };
    }

    public static class KSiege
    {        
        //Siege++ 3441eca6
        public static readonly string[] kBase ={ "3441eca6",};
        public static readonly (string name,string hex)[] kNormalmaps =
            {
                ("sg_summit","41896658"),
                ("sg_docking","4c549f4c"),
                ("sg_veil","49ebc8a9"),
                // ("sg_descent","3a1e617e"), ?Errors
                
                ("sg_isolation","65d4ad38"),
                ("sg_tachihata","419FFDFC"),
                ("sg_trimsiege","39df5dd5"),
                // ("sg_atcs","48631a3d"), Noobs&Unbalanced
            };        
        public static readonly (string name,string hex)[] kLargeMaps =
        {
            //Large Rooms
            ("sg_cave","418B1E2F"),
            ("sg_007remix","40f6995a"),
            ("sg_sorrow_siege","3A16688A"),
            ("sg_groundlerk","4c38254e"),
                
            //Unfinished
            // ("sg_undermine","4f745af9"),
            // ("sg_froyo","4c51704c"),       
        };
    }

    public static class KDefense
    {
        //Defense 258572bf
        public static readonly string[] kBase = {"258572bf" };
        public static readonly (string name,string hex)[] kMaps =
        {
            ("ns2_def_troopers","29552747"),
            ("ns2_kf_farm","2c62070a"),
            ("ns2_tow_summit_2021","9c4d87a1"),
        };
    }

    public static class KInfested
    {
        //Infested 2e813610
        public static readonly string[] kBase = { "2e813610","98B51D00" };
        
        
        public static readonly (string name,string hex)[] kMaps =
        {
            ("infest_veil", null),
            ("infest_biodome", null),
            ("infest_caged", null),
            ("infest_summit", null),
            ("infest_tram", null),
            ("infest_docking", null),
            ("infest_descent", null),
            ("infest_eclipse", null),
            ("infest_derelict", null),
            ("infest_kodiak", null),
            ("infest_metro", null),
            ("infest_mineshaft", null),
            ("infest_refinery", null),
            ("infest_unearthed", null),
            ("infest_tanith", null),
            ("infest_origin", null),
        };
    }

    public static class KGorgeRun
    {
        public static readonly string[] kBase = {"a4a89f28"};
        public static readonly (string name,string hex)[] kMaps =
            {
                ("gr_baconbits",null),
                ("gr_hamhocks",null),
                ("gr_warthogs",null),
                ("gr_sowbelly",null),
                ("gr_gorgerally",null),
            };
    }
    
    public static class KPVP
    {
        public static readonly (string name,string hex)[] kCustomMaps =
        {
            ("ns2_derelict_fixed","4230c53c"),
            ("ns2_veil_cured","575b854c"),
            ("ns2_origintonic","8f41d838"),
            ("ns2_unearthed_butbetter","454f732c"),
            ("ns2_metro_butchered","98f21e0d"),
            ("ns2_kodiak_deforested","541b2647"),
            ("ns2_biodamnnn","8d777954"),
            ("ns2_tramed","87f86e30"),
            ("ns2_mineshaft_shafted","57eb512a"),
            ("ns2_cagedfree_farmfresh","6e538c25"),
        };
    }

    public static class KSentinel
    {
        //Sentinel 492b5592
        public static readonly string[] kBase = { "492b5592"};
        public static readonly string[] kMods = {"99c77763", "99c779e7", "99d33f34", "9d145a23", "999838e9" };
    }

    public static class KSkulkWithShotgun
    {
        //Skulk With Shotgun a00af98e
        public static readonly string[] kBase = { "a00af98e" };
        public static readonly (string name,string hex)[] kMaps =
        {
            //DM
            ("ns2_sws_refinery","cb11261"),
            ("ns2_sws_ffa_tram","1136E3AC"),
            ("ns2_sws_ffa_biodome","112f2a87"),
            ("ns2_sws_metro","cb225ba"),
            ("ns2_sws_ikea","d1d175f"),
            ("ns2_sws_rr","103AFD31"), 
            ("ns2_sws_sphere","d2bc6f4"),
            
            //CTF
            ("ns2_sws_Ocala","d705e1f"),
            ("ns2_sws_xpress","d601408"),
            ("ns2_sws_gorgasm","d574214"),
            ("ns2_sws_eden_fixed2","63ff4083"),
            ("ns2_sws_fissure","d2e4e28"),
            // ("ns2_sws_2gorge","d12b1e6"),    ?
        };
    }    
    public static class KLastStand
    {
        //Last Stand 25e20012
        public static readonly string[] kBase = { "25e20012","99c77763", "99c779e7", "99d33f34", "9d145a23","999838e9" };
        public static readonly (string name,string hex)[] kMaps =
        {
            // ("ns2_ls_descent","25e6405a"),  Boring
            // ("ns2_ls_eclipse","2607a0db"), dead on spawn
            ("ns2_ls_pad",null),
            ("ns2_ls_storm","2655CD48"),
            ("ns2_ls_frost","25e6451e"),
            ("ns2_ls_hangar","25e64dc3"),
            ("ns2_ls_rockdown","25e6537d"),
            ("ns2_ls_hellevator","85e539b"),
            ("ns2_ls_traction","2655CD48"),
            // ("ns2_ls_hera","261fb86d"),  //White Box
        };
    }
}



