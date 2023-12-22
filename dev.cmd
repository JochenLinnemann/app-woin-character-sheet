pushd .

cd src/CharacterSheet.Web

start dotnet watch
start npm run buildcss -- --watch

popd
