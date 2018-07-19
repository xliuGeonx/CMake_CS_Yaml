include(CSharpUtilities)

add_executable(Example
	yamldotnet.cs)

#TARGET_LINK_LIBRARIES(Example ${YamlDotNet_DIR}/${YamlLib})

SET_PROPERTY( TARGET Example PROPERTY VS_DOTNET_REFERENCES
	${YamlDotNet_DIR}/${YamlLib}
)

#ADD_DEPENDENCIES(Example ${YamlDotNet_DIR}/${YamlLib})
