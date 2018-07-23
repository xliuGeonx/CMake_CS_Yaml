include(CSharpUtilities)

add_executable(InputFile
	InputFile.cs	
	App.config
	Properties/AssemblyInfo.cs)

csharp_set_designer_cs_properties(
	Properties/AssemblyInfo.cs)
	
set_property(TARGET InputFile PROPERTY VS_DOTNET_TARGET_FRAMEWORK_VERSION "v4.6.1")

set_property(TARGET InputFile PROPERTY WIN32_EXECUTABLE TRUE)

SET_PROPERTY( TARGET InputFile PROPERTY VS_DOTNET_REFERENCES
	${YamlDotNet_DIR}/${YamlLib}
	"System"
	"System.Core"
	"System.Data"
	"System.Data.DataSetExtensions"
	"System.Xml"
	"System.Runtime.Serialization"
	"System.Xml.Linq"
	"Microsoft.CSharp"
	"PresentationCore"
)


