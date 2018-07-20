using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
//using System.Threading;
using YamlDotNet.Serialization;

namespace yamldotnet
{
	class test
	{
		static void Main()
		{
            #region define skins
            var skinAM = new List<object>();
            skinAM.Add(
                new 
                {
                    Name = "stl_name1",
                    FileName = "fn1",
                    Type = "STL",
                    Units = 0.001,
                    Verbosity = true,
                    Tag = "Part"
                }
            );

            skinAM.Add(
                new
                {
                    Name = "stl_name2",
                    FileName = "fn2",
                    Type = "STL",
                    Units = 0.001,
                    Verbosity = true,
                    Tag = "Support"
                }
            );
            #endregion
            
            #region define materials
            var matAM = new List<object>();

            matAM.Add(
                new 
                {
                    Name = "Default1",
                    File = "f1"
                }
                );
            matAM.Add(
                new
                {
                    Name = "Default2",
                    File = "f2"
                }
                );
            #endregion

            #region defin Mappings

            object stopCriterium;
            stopCriterium = new
            {
                Type = "LayerTotalTime",
                Value = 0.001
            };

            var wkiParaDico = new Dictionary<string, string>();
            wkiParaDico["stl1"] = "Part";
            wkiParaDico["stl2"] = "Support";

            var mapping = new List<object>();
            mapping.Add
                (new 
                {
                    Name = "Mappings1",
                    Stop = stopCriterium,
                    Values = wkiParaDico
                }
                );

            #endregion

            #region define Layers
            var layerAM = new Dictionary<int, object>();
            layerAM.Add
                (1, new 
                {
                    Thickness = 0.000059999,
                    Mapping = "Mapping"
                }
                );
            layerAM.Add
                (2, new
                {
                    Thickness = 0.005,
                    Mapping = "Mapping"
                }
                );
            #endregion

            #region define BoundaryConditions
            var bcsAM = new List<object>();
            bcsAM.Add(
                new
                {
                    Name = "bc1",
                    Type = "ConstantTemperature",
                    Skin = "Part",
                    MaxZ = 0.0,
                    Value = 25.0,
                    LateralFaces = new List<object> { 
                        new int[] {-1, 0, 0},
                        new int[] {0, 0, 1}
                    }
                }
                );
            bcsAM.Add(
                new
                {
                    Name = "bc2",
                    Type = "ConstantTemperature",
                    Skin = "Support",
                    MaxZ = 0.0,
                    Value = 25.0,
                    LateralFaces = new int[] {-1, 0, 0}                    
                }
                );
            #endregion

            #region define MacroLayers
            var mlayerAM = new List<object>();
            mlayerAM.Add(
                new {
                    Id = 1,
                    LayerMinId = 1,
                    LayerMaxId = 17
                }
                );
            mlayerAM.Add(
                new
                {
                    Id = 2,
                    LayerMinId = 18,
                    LayerMaxId = 34
                }
                );
            #endregion

            #region define Octree
            dynamic octreeAM = new object();

            #endregion

            var bGraph = new
			{
				Skins = skinAM,
				Materials = matAM,
                Mappings = mapping,
                Layers = layerAM,
                BoundaryConditions = bcsAM,
                MacroLayers = mlayerAM
			};
			
			var sb = new SerializerBuilder();
			//sb.DisableAliases();
			using (var tw = File.CreateText("input.yml"))
			{
                sb.Build().Serialize(tw, bGraph);
            };
                      
			Console.WriteLine("work");
		}		
	}
}
