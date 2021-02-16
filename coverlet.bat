:: Store current directory
set local=%~dp0

dotnet clean
dotnet build /p:DebugType=Full

:: Unit Tests
dotnet test ".\tests\Hackerrank.Tests\Hackerrank.Tests.csproj" ^
/p:CollectCoverage=true ^
/p:CoverletOutputFormat=cobertura ^
/p:Exclude=\^"^
[*.*]Hackerrank.ConsoleApp.Program,^
/p:threshold=85 /p:thresholdType=line /p:thresholdStat=total --no-build

:: Report generator
cd %local%

reportgenerator "-reports:.\tests\Hackerrank.Tests\coverage.cobertura.xml;" ^
"-targetdir:coverage" -reporttypes:Cobertura;HtmlInline

cd %local%
start ./coverage/index.htm

:: Clear data
del ".\tests\Hackerrank.Tests\coverage.cobertura.xml"