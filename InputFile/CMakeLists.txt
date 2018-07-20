include(CSharpUtilities)

add_executable(InputFile
	InputFile.cs)


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


