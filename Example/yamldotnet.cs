using System;
using System.Collections.Generic;
//using System.Diagnostics;
using System.Dynamic;
//using System.Globalization;
using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading;
using YamlDotNet.Serialization;

namespace yamldotnet
{
	class test
	{
		static void Main()
		{
            //dynamic dobj = "Hi I am Dynamic ";
			var bGraph = new
			{
				skin = "skin",
				material = "material"
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
