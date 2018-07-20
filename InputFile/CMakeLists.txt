include(CSharpUtilities)

add_executable(InputFile
	InputFile.cs)


SET_PROPERTY( TARGET InputFile PROPERTY VS_DOTNET_REFERENCES
	${YamlDotNet_DIR}/${YamlLib}
)


